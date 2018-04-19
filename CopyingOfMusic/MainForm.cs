using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyingOfMusic
{
    public partial class MainForm : Form
    {
        CopyControl copying = new CopyControl();
        Helper helper;

        public MainForm()
        {
            InitializeComponent();
            helper = new Helper(progressCopying, songName);
            copying.HandlerAction += helper.RaiseHandler;
        }

        private void btnDirectoryFrom_Click(object sender, EventArgs e)
        {
            helper.ChooseDirectory(copying, Helper.PathType.PathFrom);
        }

        private void btnChooseDirectoryTo_Click(object sender, EventArgs e)
        {
            helper.ChooseDirectory(copying, Helper.PathType.NewPath);
        }

        private async void btnCopyMusic_Click(object sender, EventArgs e)
        {
            try
            {
                copying.GetKnowCopyingDetails(progressCopying, extensionsBox);
                await copying.CopyMusicToAsync();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            copying.CancellationToken.Cancel();
        }
    }
}
