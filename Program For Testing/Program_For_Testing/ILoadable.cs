using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_For_Testing
{
    interface ILoadable
    {
        void OpenDocument(string name);
        void NewDocument();
        void CloseDocument();
    }
}
