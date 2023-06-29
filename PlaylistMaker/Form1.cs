using System.ComponentModel.DataAnnotations;

namespace PlaylistMaker
{
    public partial class Form1 : Form
    {
        private DirectoryInfo? selectedRootFolder;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFolderSelectBtn_Click(object sender, EventArgs e)
        {
            var folderPicker = new FolderPicker();
            if (folderPicker.ShowDialog(Handle) == true)
            {
                var rootFolder = folderPicker.ResultPath;
                var dirInfo = new DirectoryInfo(rootFolder);
                selectedRootFolder = dirInfo;
                var rootName = dirInfo.Name;

                var treeRoot = new TreeNode(rootName);
                treeRoot = BuildTreeNote(treeRoot, dirInfo);
                treeRoot.Checked = true;
                treeRoot.Expand();

                folderTreeview.Nodes.Clear();
                folderTreeview.Nodes.Add(treeRoot);
            }
        }

        private List<DirectoryInfo> GetCheckedFolder(TreeNodeCollection nodes, DirectoryInfo rootDirectory)
        {
            var checkedFolder = nodes.Descendants()
                .Where(n => n.Checked)
                .Select(n => n.FullPath)
                .ToList();
            var folderFullPath = new List<DirectoryInfo>();
            foreach (var dir in checkedFolder)
            {
                folderFullPath.Add(new DirectoryInfo(Path.Combine(rootDirectory.FullName, dir)));
            }
            return folderFullPath;
        }

        private TreeNode BuildTreeNote(TreeNode root, DirectoryInfo rootDirectory)
        {
            try
            {
                foreach (var dir in rootDirectory.GetDirectories())
                {
                    var childNode = new TreeNode(dir.Name);
                    var childDirInfo = new DirectoryInfo(dir.FullName);
                    childNode = BuildTreeNote(childNode, childDirInfo);
                    childNode.Checked = true;
                    root.Nodes.Add(childNode);
                }
                return root;
            }
            catch (UnauthorizedAccessException)
            {
                return root;
            }
        }

        public void CheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = true;
                CheckChildren(node, true);
            }
        }

        public void UncheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;
                CheckChildren(node, false);
            }
        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                node.Checked = isChecked;
            }
        }

        private void folderTreeview_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var a = e;
        }

        private void folderTreeview_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckChildren(e.Node, e.Node.Checked);
        }

        private void buildPlaylistBtn_Click(object sender, EventArgs e)
        {
            if (selectedRootFolder != null)
            {
                var folders = GetCheckedFolder(folderTreeview.Nodes, selectedRootFolder.Parent);
                string? excludePattern = String.IsNullOrWhiteSpace(excludePatternInput.Text) ? null : excludePatternInput.Text;

                var playlist = PlaylistMaker.GenerateM3U8(folders, excludePattern);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "M3U8 Playlist|*.m3u8";
                saveFileDialog.Title = "Save m3u8 playlist";
                saveFileDialog.DefaultExt = "m3u8";
                saveFileDialog.FileName = "Playlist";
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, playlist);
                    MessageBox.Show("Playlist saved!");
                }
            }
        }
    }

    public static class TreeNodeCollectionExtension
    {
        internal static IEnumerable<TreeNode> Descendants(this TreeNodeCollection c)
        {
            foreach (var node in c.OfType<TreeNode>())
            {
                yield return node;

                foreach (var child in node.Nodes.Descendants())
                {
                    yield return child;
                }
            }
        }
    }
}