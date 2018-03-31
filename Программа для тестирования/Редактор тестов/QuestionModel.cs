using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Редактор_тестов
{
    class QuestionModel 
    {
        public string question { get; set; }

        public Dictionary<bool, string> answers = new Dictionary<bool, string>();
        
    }
}
