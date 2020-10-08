using System.Collections.Generic;
using System.IO;

namespace Test
{
    public class FolderManager
    {
        private readonly string dstImgPath;
        public string dstPath;

        public FolderManager(string dstPath, string dstFolderName)
        {
            this.dstPath = dstPath + dstFolderName;
            dstImgPath = this.dstPath + @"\image";
        }

        public void foldersBuild()
        {
            Directory.CreateDirectory(dstPath);
            Directory.CreateDirectory(dstImgPath);
        }

        // copy all image on img path from all image with numbers
        public void copyImgToDir(string imgPath, List<string> imgNo)
        {
            if (Directory.Exists(imgPath))
            {
                var files = Directory.GetFiles(imgPath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (var s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    var fileName = Path.GetFileName(s);
                    var fileNameNoExtension = fileName.Split('.')[0];
                    if (imgNo.Contains(fileNameNoExtension))
                    {
                        var destFile = Path.Combine(dstImgPath, fileName);
                        File.Copy(s, destFile, true);
                    }
                }
            }
        }
    }
}