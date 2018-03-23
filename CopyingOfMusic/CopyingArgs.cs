using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingOfMusic
{
    class CopyingArgs
    {
        public string Message { get; set; }
        public int Step { get; set; }
        public CopyingArgs(string message, int step)
        {
            Message = message;
            Step = step;
        }
    }
}
