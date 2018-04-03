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
            PointForQuestion = 0;
            TrueAswers = 0;
            SaveQuestion = false;
        }
        public string question { get; set; }
        public double PointForQuestion { get; set; }
        public int TrueAswers { get; set; }
        public bool SaveQuestion { get; set; }
        public Dictionary<string,bool> CloneAnswers()
        {
            return new Dictionary<string, bool>(answers);
        }
        public QuestionModel Clone()
        {
            return new QuestionModel { question = this.question, PointForQuestion = this.PointForQuestion,
                TrueAswers = this.TrueAswers,
                SaveQuestion = this.SaveQuestion,
                answers = CloneAnswers()
            };
        }

        public Dictionary<string,bool> answers = new Dictionary<string, bool>();

    }
}
