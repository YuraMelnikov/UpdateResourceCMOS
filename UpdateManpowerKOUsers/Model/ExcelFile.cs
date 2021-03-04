using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace UpdateManpowerKOUsers.Model
{
    class ExcelFile
    {
        readonly string pathFileRP = "M:\\Katek\\Pror&D\\Archive\\Предразработка\\Прогноз по выработке нормо-часов.xlsm";
        List<DataInExcel> dataInExcel = new List<DataInExcel>();

        internal List<DataInExcel> DataInExcel { get => dataInExcel; set => dataInExcel = value; }

        public void UploadDataInListDataInExcel(string listName)
        {
            Excel.Application ObjWorkExcel = new Excel.Application();
            Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(pathFileRP, 0, true, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[listName];
            string textData = "";
            int column = 4;
            int row = 2;
            textData = ObjWorkSheet.Cells[row, column].Text.ToString();
            DataExcel[] array = GetDefaultDataInExcel(textData);
            while (textData != "")
            {
                textData = ObjWorkSheet.Cells[row, column].Text.ToString();
                array = GetDefaultDataInExcel(textData);
                Console.WriteLine(textData);
                row += 2;
                column += 1;
                for (int i = 0; i < 180; i++)
                {
                    string tmp = ObjWorkSheet.Cells[row + i, column - 1].Text;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j].Month == ObjWorkSheet.Cells[row + i, column - 1].Text)
                        {
                            array[j].Data = Convert.ToDouble(ObjWorkSheet.Cells[row + i, column].Text);
                        }
                    }
                }
                double startPosition = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    startPosition = array[i].Data;
                    if (startPosition > 0)
                        break;
                }
                if (startPosition == 0)
                    startPosition = 0.5;
                array[0].Data = startPosition;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i].Data == 0)
                        array[i].Data = array[i - 1].Data;
                }
                AddDataInExcel(array);
                PrintUploadResultExcel(array);
                column += 3;
                row = 2;
            }

            //ObjWorkBook.Close();
            ObjWorkExcel.Quit();

            //Marshal.ReleaseComObject(ObjWorkBook);
            Marshal.ReleaseComObject(ObjWorkExcel);
        }

        DataExcel[] GetDefaultDataInExcel(string userName)
        {
            DataExcel[] array = new DataExcel[12];
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            for (int i = 0; i < 12; i++)
            {
                array[i] = new DataExcel
                {
                    UserName = userName,
                    Month = year + "." + GeMonthLongString(month),
                    Data = 0.0,
                    NumberMonth = month
                };
                month++;
                if (month == 13)
                {
                    month = 1;
                    year++;
                }
            }
            return array;
        }

        string GeMonthLongString(int month)
        {
            if (month > 9)
                return month.ToString();
            else
                return "0" + month.ToString();
        }

        bool PrintUploadResultExcel(DataExcel[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} | {1} | {2}", array[i].UserName, array[i].Month, array[i].Data);
            }
            return true;
        }

        bool AddDataInExcel(DataExcel[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                DataInExcel dataInExcels = new DataInExcel(array[i].Data, array[i].NumberMonth, array[i].UserName);
                DataInExcel.Add(dataInExcels);
            }
            return true;
        }
    }
}
