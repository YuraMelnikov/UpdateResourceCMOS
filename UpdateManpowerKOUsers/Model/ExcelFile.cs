using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace UpdateManpowerKOUsers.Model
{
    class ExcelFile
    {
        string pathFileRP = "M:\\Katek\\Pror&D\\Archive\\Предразработка\\Прогноз по выработке нормо-часов.xlsm";
        string nameListExcel = "Расчет коэф. КБМ";
        List<DataInExcel> dataInExcel = new List<DataInExcel>();
        Excel.Application ObjWorkExcel = new Excel.Application();

        internal List<DataInExcel> DataInExcel { get => dataInExcel; set => dataInExcel = value; }

        public void UploadDataInListDataInExcel()
        {
            Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(pathFileRP, 0, true, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[nameListExcel];
            
            string textData = "";
            int column = 4;
            int row = 2;
            textData = ObjWorkSheet.Cells[row, column].Text.ToString();
            while (textData != "")
            {
                Console.WriteLine(textData);
                row += 2;
                column += 1;
                while (ObjWorkSheet.Cells[row, column].Text.ToString() == "")
                {
                    row++;
                    if (row > 1000)
                        break;
                }
                for (int i = 0; i < 12; i++)
                {
                    try
                    {
                        DataInExcel.Add(new DataInExcel(Convert.ToDouble(ObjWorkSheet.Cells[row, column].Text), DateTime.Now.AddMonths(i).Month, textData));
                        Console.WriteLine();
                    }
                    catch
                    {
                        row = 13;
                    }
                    row++;
                }
                column += 3;
                row = 2;
                try
                {
                    textData = ObjWorkSheet.Cells[row, column].Text.ToString();
                }
                catch
                {
                    textData = "";
                }
            }
        }
    }
}
