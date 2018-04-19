using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace CopyingOfMusic
{
    class CopyControl
    {
        private CancellationTokenSource cancellationToken = new CancellationTokenSource();
        public event EventHandler<CopyingEventArgs> HandlerAction;

        public string newPath = String.Empty;
        public string pathFrom = String.Empty;
        public string fileExtension = String.Empty;

        public CancellationTokenSource CancellationToken => cancellationToken;

        public async Task CopyMusicToAsync()
        {
            DirectoryInfo di = new DirectoryInfo(pathFrom);
            List<FileInfo> files = di.GetFiles(fileExtension, SearchOption.TopDirectoryOnly).ToList();

            if (!Validate(newPath, pathFrom, fileExtension))
            {
                MessageBox.Show("The entered data is not correct!", "Warning!");
                return;
            }

            await Task.Run(() =>
            {
                foreach (FileInfo file in files)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        MessageBox.Show("Canceled");
                        return;
                    }
                    else if (!File.Exists(Path.Combine(newPath, file.Name)))
                    {
                        OnCopyHandler(new CopyingEventArgs(file.Name, 1));
                        File.Copy(file.FullName, Path.Combine(newPath, file.Name));
                    }
                }
                MessageBox.Show("Copying is done!", "Result");
            });
        }

        public bool Validate(params string[] data)
        {
            bool valid = true;
            foreach (string item in data)
            {
                if (String.IsNullOrEmpty(item))
                    valid = false;
            }
            return valid;
        }

        public void GetKnowCopyingDetails(ProgressBar progressBar, ComboBox comboBox)
        {
            fileExtension = (string)comboBox.SelectedItem ?? "";
            int count = Directory.GetFiles(pathFrom, fileExtension, SearchOption.AllDirectories).Count();
            progressBar.Maximum = count;
            progressBar.Step = count / 100;
        }

        private void OnCopyHandler(CopyingEventArgs copyArgs)
        {
            EventHandler<CopyingEventArgs> handler = HandlerAction;
            if (handler != null)
            {
                handler(this, copyArgs);
            }
        }
    }
}
