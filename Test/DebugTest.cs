namespace Test
{
    public class DebugTest
    {
        public static void xlsTest()
        {
            var xlsPath = @"D:\Desktop\CAUDRON 16 juillet 2020 vacation étude.xls";
            var xlsMan = new XlsxManager(xlsPath);
            xlsMan.exctractUnsaled();
            xlsMan.buildXls(@"D:\Desktop\dst.xls");
        }

        public static void folderTest()
        {
            var dstPath2 = @"D:\Desktop\";
            var dstFolderName2 = "CAUDRON 16 juillet 2020 vacation étude INVENDU";

            var xlsPath = @"D:\Desktop\CAUDRON 16 juillet 2020 vacation étude.xls";
            var xlsMan = new XlsxManager(xlsPath);
            xlsMan.exctractUnsaled();


            var fo = new FolderManager(dstPath2, dstFolderName2);


            fo.foldersBuild();

            xlsMan.buildXls(fo.dstPath + @"\" + dstFolderName2 + ".xls");
            fo.copyImgToDir(dstPath2 + "image", xlsMan.rowNbs);
        }
    }
}