namespace PlaylistMaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderTreeview = new System.Windows.Forms.TreeView();
            this.openFolderSelectBtn = new System.Windows.Forms.Button();
            this.buildPlaylistBtn = new System.Windows.Forms.Button();
            this.excludePatternInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderTreeview
            // 
            this.folderTreeview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTreeview.CheckBoxes = true;
            this.folderTreeview.Location = new System.Drawing.Point(3, 37);
            this.folderTreeview.Name = "folderTreeview";
            this.folderTreeview.Size = new System.Drawing.Size(350, 386);
            this.folderTreeview.TabIndex = 0;
            this.folderTreeview.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.folderTreeview_AfterCheck);
            this.folderTreeview.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.folderTreeview_BeforeExpand);
            // 
            // openFolderSelectBtn
            // 
            this.openFolderSelectBtn.Location = new System.Drawing.Point(3, 3);
            this.openFolderSelectBtn.Name = "openFolderSelectBtn";
            this.openFolderSelectBtn.Size = new System.Drawing.Size(100, 23);
            this.openFolderSelectBtn.TabIndex = 1;
            this.openFolderSelectBtn.Text = "Select Folder";
            this.openFolderSelectBtn.UseVisualStyleBackColor = true;
            this.openFolderSelectBtn.Click += new System.EventHandler(this.openFolderSelectBtn_Click);
            // 
            // buildPlaylistBtn
            // 
            this.buildPlaylistBtn.Location = new System.Drawing.Point(3, 3);
            this.buildPlaylistBtn.Name = "buildPlaylistBtn";
            this.buildPlaylistBtn.Size = new System.Drawing.Size(93, 23);
            this.buildPlaylistBtn.TabIndex = 2;
            this.buildPlaylistBtn.Text = "Build Playlist";
            this.buildPlaylistBtn.UseVisualStyleBackColor = true;
            this.buildPlaylistBtn.Click += new System.EventHandler(this.buildPlaylistBtn_Click);
            // 
            // excludePatternInput
            // 
            this.excludePatternInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.excludePatternInput.Location = new System.Drawing.Point(3, 70);
            this.excludePatternInput.Name = "excludePatternInput";
            this.excludePatternInput.Size = new System.Drawing.Size(348, 23);
            this.excludePatternInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "File exclude pattern\r\n(Case-insensitive)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.openFolderSelectBtn);
            this.splitContainer1.Panel1.Controls.Add(this.folderTreeview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buildPlaylistBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.excludePatternInput);
            this.splitContainer1.Size = new System.Drawing.Size(714, 426);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Playlist Builder";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView folderTreeview;
        private Button openFolderSelectBtn;
        private Button buildPlaylistBtn;
        private TextBox excludePatternInput;
        private Label label1;
        private SplitContainer splitContainer1;
    }
}