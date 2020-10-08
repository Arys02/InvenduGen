namespace Test
{
    public class OutputGen
    {
        private readonly string dstPath;
        private readonly string imgPath;
        private readonly XlsxManager xlsMan;
        private readonly string xlsPath;


        public OutputGen(string xlsPath, string imgPath, string dstPath)
        {
            xlsMan = new XlsxManager(xlsPath);
            this.xlsPath = xlsPath;
            this.imgPath = imgPath;
            this.dstPath = dstPath + @"\";
        }

        public void run()
        {
            var dstFolderNameArr = xlsPath.Split('\\');
            var dstFolderName = dstFolderNameArr[dstFolderNameArr.Length - 1].Split('.')[0] + " INVENDUS";


            xlsMan.exctractUnsaled();


            var fo = new FolderManager(dstPath, dstFolderName);


            fo.foldersBuild();

            xlsMan.buildXls(fo.dstPath + @"\" + dstFolderName + ".xls");
            fo.copyImgToDir(imgPath, xlsMan.rowNbs);
        }
    }
}