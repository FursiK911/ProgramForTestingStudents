using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Program_For_Testing
{
    class ExSave : ISave
    {

        // Создаём экземпляр нашего приложения
        private Excel.Application excelApp = new Excel.Application();
        // Создаём экземпляр рабочий книги Excel
        private Excel.Workbook workBook;
        // Создаём экземпляр листа Excel
        private Excel.Worksheet workSheet;
        private Participant participant;

        public ExSave(Participant p)
        {
            participant = p;
        }


        public void CloseDocument()
        {
        }

        public void NewDocument()
        {

            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            workSheet.Cells[1, 1] = "ФИО";
            workSheet.Cells[1, 2] = "Специальность";
            workSheet.Cells[1, 3] = "Курс";
            workSheet.Cells[1, 4] = "Баллы";


            //// Заполняем первую строку числами от 1 до 10
            //for (int j = 1; j <= 10; j++)
            //{
            //    workSheet.Cells[1, j] = j;
            //}
            //// Вычисляем сумму этих чисел
            //Excel.Range rng = workSheet.Range["A2"];
            //rng.Formula = "=SUM(A1:L1)";
            //rng.FormulaHidden = false;

            //// Выделяем границы у этой ячейки
            //Excel.Borders border = rng.Borders;
            //border.LineStyle = Excel.XlLineStyle.xlContinuous;

            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        public void OpenDocument(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveDocument(string name)
        {
            //for (int i = 1; ; i++)
            //{
            //    if(workSheet. == "")
            //    {
            //        workSheet.Cells[i, 1] = participant.FullName;
            //        workSheet.Cells[i, 2] = participant.Specialty;
            //        workSheet.Cells[i, 3] = participant.Course;
            //        workSheet.Cells[i, 4] = participant.Points;
            //        break;
            //    }
            //}
        }
    }
}
