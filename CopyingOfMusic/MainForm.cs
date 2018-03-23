using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyingOfMusic
{
    public partial class MainForm : Form
    {
        ControlCopying copying = new ControlCopying();
        double step;
        int count;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDirectoryFrom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if(folderBrowser.ShowDialog()==DialogResult.OK)
            {
                copying.pathFrom = folderBrowser.SelectedPath;
            }
        }

        private void btnChooseDirectoryTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                copying.newPath = folderBrowser.SelectedPath;
            }
        }

        private void btnCopyMusic_Click(object sender, EventArgs e)
        {
            try
            {
                copying.GetKnowStepOfCopying(out step, out count);
                progressCopying.Maximum = count;
                progressCopying.Step = (int)step;
                copying.HandlerAction += Raise_HandlerAction;
                copying.CopyMusicTo();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void Raise_HandlerAction(object sender, CopyingArgs e)
        {
            songName.Invoke(new Action(() => { songName.AppendText(e.Message); songName.AppendText(Environment.NewLine); }));
            progressCopying.Invoke(new Action(() => progressCopying.Value += e.Step));
        }
    }
}
