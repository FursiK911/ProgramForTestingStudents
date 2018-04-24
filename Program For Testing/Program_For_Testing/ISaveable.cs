using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_For_Testing
{
    interface ISaveable
    {
        void SaveAsDocument(string name);
        void SaveDocument();
    }
}
