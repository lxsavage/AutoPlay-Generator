using System;
using System.Windows.Forms;

namespace AutoPlay_Generator
{
    public partial class SaveSuccessPrompt : Form
    {
        public SaveSuccessPrompt()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
