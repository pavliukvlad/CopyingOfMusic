using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace CopyingOfMusic
{
    class ControlCopying
    {
        public string newPath = String.Empty;
        public string pathFrom = String.Empty;
        

        public event EventHandler<CopyingArgs> HandlerAction;

        public void CopyMusicTo()
        {
            Console.WriteLine();
            DirectoryInfo di = new DirectoryInfo(pathFrom);
            List<FileInfo> files = di.GetFiles("*.mp3", SearchOption.TopDirectoryOnly).ToList();

            foreach (FileInfo file in files)
            {
                if (!File.Exists(Path.Combine(newPath, file.Name)))
                {
                    OnCopyHandler(new CopyingArgs(file.Name, 1));
                    File.Copy(file.FullName, Path.Combine(newPath, file.Name));
                }
            }
            MessageBox.Show("Copying is done!", "Result");
        }
        public void GetKnowStepOfCopying(out double step, out int count)
        {
            count = Directory.GetFiles(pathFrom, "*.mp3", SearchOption.TopDirectoryOnly).Count();
            step = count / 100;
        }
        private void OnCopyHandler(CopyingArgs copyArgs)
        {
            EventHandler<CopyingArgs> handler = HandlerAction;
            if (handler != null)
            {
                handler(this, copyArgs);
            }
        }
    }
}
