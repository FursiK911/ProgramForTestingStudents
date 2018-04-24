using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TestEditor;

namespace Program_For_Testing
{
    class ExcelService : ISaveable , ILoadable
    {

        // Создаём экземпляр нашего приложения
        private Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        // Создаём экземпляр рабочий книги Excel
        private Excel.Workbook xlWorkBook;
        // Создаём экземпляр листа Excel
        private Excel.Worksheet xlWorkSheet;
        private object misValue = System.Reflection.Missing.Value;
        private Participant participant;
        private TestModel test;

        public ExcelService(Participant p, TestModel t)
        {
            participant = p;
            test = t;
        }

        public void CloseDocument()
        {
            xlWorkBook.Close(true, Type.Missing, Type.Missing);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        public void NewDocument()
        {
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            var xlSheets = xlWorkBook.Sheets as Excel.Sheets;
            var xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
            xlNewSheet.Name = test.Topic;
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        }

        public void OpenDocument(string name)
        {
            bool topicExists = false;
            xlWorkBook = xlApp.Workbooks.Open(name, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            for (int i = 1; i < xlWorkBook.Sheets.Count; i++)
            {
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(i);
                if (xlWorkSheet.Name == test.Topic)
                {
                    topicExists = true;
                    break;
                }
            }

            if (!topicExists)
            {
                var xlSheets = xlWorkBook.Sheets as Excel.Sheets;
                var xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                xlNewSheet.Name = test.Topic;
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            }
        }

        public void SaveAsDocument(string name)
        {
            xlWorkBook.SaveAs(name, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

        }

        public void SaveDocument()
        {
            xlWorkBook.Save();

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool ExcelIsPresent()
        {
            if (xlApp == null)
            {
                MessageBox.Show("Excel установлен не правильно!");
                return false;
            }
            return true;
        }

        public void WriteData()
        {
            xlWorkSheet.Cells[1, 1] = "ФИО";
            xlWorkSheet.Cells[1, 2] = "Специальность";
            xlWorkSheet.Cells[1, 3] = "Курс";
            xlWorkSheet.Cells[1, 4] = "Группа";
            xlWorkSheet.Cells[1, 5] = "Баллы";

            for (int i = 1; ; i++)
            {
                string x = xlWorkSheet.Cells[i, 1].Text;
                if (x == "")
                {
                    xlWorkSheet.Cells[i, 1] = participant.FullName;
                    xlWorkSheet.Cells[i, 2] = participant.Specialty;
                    xlWorkSheet.Cells[i, 3] = participant.Course;
                    xlWorkSheet.Cells[i, 4] = participant.Group;
                    xlWorkSheet.Cells[i, 5] = participant.DoFormat(participant.Points);
                    break;
                }
            }
        }
    }
}
