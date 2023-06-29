using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlaylistMaker
{
    public static class PlaylistMaker
    {
        public static readonly string[] AudioFileExts = { ".mp3", ".wav", ".wma", ".aac", ".flac", ".ogg", ".alac", ".aiff", ".cue", ".m4a" };

        public static string GenerateM3U8(IEnumerable<DirectoryInfo> directories, string? excludeFilter = null)
        {
            // Create playlist from files in directoreis, in m3u8 format
            StringBuilder sb = new();

            // Set the regex options to ignore case
            RegexOptions options = RegexOptions.IgnoreCase;

            // Add the M3U8 header
            sb.AppendLine("#EXTM3U");

            // Loop through each directory
            foreach (DirectoryInfo directory in directories)
            {
                // Loop through each audio file in the directory
                foreach (FileInfo file in directory.GetFiles().Where(f => AudioFileExts.Contains(f.Extension.ToLower())))
                {
                    // Check if the file should be excluded based on the excludeFilter regex
                    if (excludeFilter != null && Regex.IsMatch(file.Name, excludeFilter, options))
                    {
                        continue; // Skip this file and move on to the next file
                    }

                    // Add the file to the playlist
                    sb.AppendLine(file.FullName);
                }
            }

            // Return the M3U8 playlist as a string
            return sb.ToString();
        }
    }
}
