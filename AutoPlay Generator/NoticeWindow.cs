using System;
using System.Windows.Forms;

namespace AutoPlay_Generator
{
    public partial class NoticeWindow : Form
    {
        public NoticeWindow() => InitializeComponent();

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarningLine1_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
