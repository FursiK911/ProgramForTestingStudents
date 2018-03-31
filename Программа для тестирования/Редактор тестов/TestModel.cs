using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Редактор_тестов
{
    class TestModel
    {
        public string AcademicDiscipline { get; set; }
        public string Topic { get; set; }
        public int AmountQuestions { get; set; }

        public List <QuestionModel> questions = new List<QuestionModel>();
    }
}
