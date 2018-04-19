using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingOfMusic
{
    class CopyingEventArgs
    {
        public string Message { get; set; }
        public int Step { get; set; }
        public CopyingEventArgs(string message, int step)
        {
            Message = message;
            Step = step;
        }
    }
}
