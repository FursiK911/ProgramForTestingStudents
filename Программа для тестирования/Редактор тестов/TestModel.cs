using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Редактор_тестов
{
    public class TestModel
    {
        public TestModel()
        {
            AcademicDiscipline = "None";
            Topic = "None";
            AmountQuestions = 0;
            MaxPoints = 0;
            DefaultTest = true;
            DefaultPoint = 0;
        }
        public string AcademicDiscipline { get; set; }
        public string Topic { get; set; }
        public int AmountQuestions { get; set; }
        public int MaxPoints { get; set; }
        public bool DefaultTest { get; set; }
        public int DefaultPoint { get; set; }
        public string newAnswer { get; set; }

        public List <QuestionModel> questions = new List<QuestionModel>();
    }
}
