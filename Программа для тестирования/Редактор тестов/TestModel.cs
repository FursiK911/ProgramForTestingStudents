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
            Path = "";
            AmountQuestions = 0;
            MaxPoints = 0;
            DefaultTest = true;
            DefaultPoint = 0;
        }
        public string AcademicDiscipline { get; set; }
        public string Topic { get; set; }
        public int AmountQuestions { get; set; }
        public double MaxPoints { get; set; }
        public bool DefaultTest { get; set; }
        public double DefaultPoint { get; set; }
        public string NewAnswer { get; set; }
        public string Path { get; set; }

        public List <QuestionModel> questions = new List<QuestionModel>();
    }
}
