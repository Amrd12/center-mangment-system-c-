using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;

namespace student_enrolled.forms
{
    internal class ExcelWriter
    {
        public void WriteToExcel(string filePath, DataTable table)
        {
            using (SpreadsheetDocument spreadsheetDoc = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = spreadsheetDoc.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                Sheets sheets = spreadsheetDoc.WorkbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = spreadsheetDoc.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                sheets.Append(sheet);

                var sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Add column headers to the sheet
                Row headerRow = new Row();
                foreach (DataColumn column in table.Columns)
                {
                    headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(column.ColumnName) });
                }
                sheetData.AppendChild(headerRow);

                // Add rows to the sheet
                foreach (DataRow row in table.Rows)
                {
                    Row dataRow = new Row();
                    foreach (var item in row.ItemArray)
                    {
                        Cell cell = new Cell();
                        cell.DataType = new EnumValue<CellValues>(CellValues.String);
                        cell.CellValue = new CellValue(item.ToString());
                        dataRow.AppendChild(cell);
                    }
                    sheetData.AppendChild(dataRow);
                }
            }
        }
    }
}
