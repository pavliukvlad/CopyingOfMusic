using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyingOfMusic
{
    class Helper
    {
        public enum PathType
        {
            NewPath,
            PathFrom
        }

        public ProgressBar ProgressBar { get; set; }
        public TextBox TextBox { get; set; }

        public Helper(ProgressBar progressBar, TextBox textBox)
        {
            ProgressBar = progressBar;
            TextBox = textBox;
        }

        public void RaiseHandler(object sender, CopyingEventArgs e)
        {
            TextBox.Invoke(new Action(() => { TextBox.AppendText(e.Message); TextBox.AppendText(Environment.NewLine); }));
            ProgressBar.Invoke(new Action(() => ProgressBar.Value += e.Step));
        }

        public void ChooseDirectory(CopyControl obj, PathType pathType)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathType == PathType.PathFrom)
                    obj.pathFrom = folderBrowser.SelectedPath;
                else
                    obj.newPath = folderBrowser.SelectedPath;                    
            }
        }
    }
}
