using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEditor
{
    public class TestModel
    {
        public TestModel()
        {
            AcademicDiscipline = "None";
            Topic = "None";
            Path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Testing of Students\\Tests\\";
            AmountQuestions = 0;
            MaxPoints = 0;
            DefaultTest = true;
            DefaultPoint = 0;
            CreateWorkSpace();
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

        public void CreateWorkSpace()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Testing of Students";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Testing of Students\\Tests";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Testing of Students\\Results";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
        public string DoFormat(double Points)
        {
            var s = string.Format("{0:0.00}", Points);

            if (s.EndsWith("00"))
            {
                return ((int)Points).ToString();
            }
            else
            {
                return s;
            }
        }
    }
}
