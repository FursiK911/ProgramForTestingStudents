using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Редактор_тестов;

namespace Программа_для_тестирования
{
    public class Participant
    {
        public Participant()
        {
            Points = 0;
        }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public double Points { get; set; }

        public List<QuestionModel> questions = new List<QuestionModel>();
    }
}
