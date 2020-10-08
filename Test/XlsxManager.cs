using System.Collections.Generic;
using System.Diagnostics;
using ExcelLibrary.SpreadSheet;

namespace Test
{
    public class XlsxManager
    {
        private readonly List<Row> extractedRows;
        private readonly Workbook workbook;
        private Worksheet newWorksheet;

        public XlsxManager(string xlsPath)
        {
            workbook = Workbook.Load(xlsPath);
            rowNbs = new List<string>();
            extractedRows = new List<Row>();
            newWorksheet = new Worksheet("First Sheet");
        }

        public List<string> rowNbs { get; }

        public void exctractUnsaled()
        {
            var worksheet = workbook.Worksheets[0]; // assuming only 1 worksheet
            
            
            var cells = worksheet.Cells;
            newWorksheet.Cells.Rows.Add(0, cells.GetRow(0));
            newWorksheet.Cells.Rows.Add(1, cells.GetRow(1));

            extractedRows.Add(cells.GetRow(0));
            extractedRows.Add(cells.GetRow(1));
            extractedRows.Add(cells.GetRow(2));
            
            for (var i = 3; i < cells.Rows.Count; i++)
                try
                {
                    if (cells.Rows[i].GetCell(8).IsEmpty)
                        continue;

                    
                    newWorksheet.Cells.Rows.Add(i, cells.Rows[i]);
                    
                    
                    extractedRows.Add(cells.GetRow(i));
                    
                    rowNbs.Add(cells.Rows[i].GetCell(2).ToString());
                }
                catch
                {
                    // ignored
                }
        }

        public void buildXls(string dstPath)
        {
            var newWorkbook = new Workbook();
            var newWorksheet = new Worksheet("First Sheet");

            var erowCount = extractedRows.Count;
            for (var i = 0; i < erowCount; i++)
            {
                var extracticol = extractedRows[i].LastColIndex;
                
                for (var j = 0; j < extracticol; j++)
                    newWorksheet.Cells[i, j] = extractedRows[i].GetCell(j);
            }
               
                
            
            newWorkbook.Worksheets.Add(newWorksheet);
            newWorkbook.Save(
                dstPath); // open xls file Workbook book = Workbook.Load(file); Worksheet sheet = book.Worksheets[0]; 
        }
    }
}