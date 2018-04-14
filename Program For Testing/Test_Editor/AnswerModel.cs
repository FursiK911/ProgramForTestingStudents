using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEditor
{
    public class AnswerModel
    {
        public string answer { get; set; }
        public bool isCorrect { get; set; }
        public AnswerModel Clone()
        {
            return new AnswerModel { answer = this.answer, isCorrect = this.isCorrect };
        }
        public void Add(string ans, bool correct)
        {
            answer = ans;
            isCorrect = correct;
        }
    }
}
