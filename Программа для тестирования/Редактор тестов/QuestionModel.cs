using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Редактор_тестов
{
    public class QuestionModel 
    {
        public QuestionModel()
        {
            question = "None";
            PointForQuestion = 1;
            TrueAswers = 1;
            SaveQuestion = false;
        }
        public string question { get; set; }
        public int PointForQuestion { get; set; }
        public int TrueAswers { get; set; }
        public bool SaveQuestion { get; set; }

        public Dictionary<string,bool> answers = new Dictionary<string, bool>();

    }
}
