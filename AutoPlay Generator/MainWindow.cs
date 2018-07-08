using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AutoPlay_Generator
{
    public partial class MainWindow : Form
    {
        public MainWindow() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            //new NoticeWindow().ShowDialog();
        }

        private void LoadFileLI_Click(object sender, EventArgs e)
        {
            if (FilePromptLI.ShowDialog() == DialogResult.OK)
            {
                IconTextBox.Text = FilePromptLI.SafeFileName;
            }
        }

        private void LoadFileLP_Click(object sender, EventArgs e)
        {
            if (FilePromptLP.ShowDialog() == DialogResult.OK)
            {
                OpenTextBox.Text = FilePromptLP.SafeFileName;
            }
        }

        private void UFDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (UFDCheckbox.Checked)
            {
                AutoRunGroupBox.Enabled = false;
            }
            else
            {
                AutoRunGroupBox.Enabled = true;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // Check to see if at least one field is filled out
            if (LabelTextBox.Text == "" && IconTextBox.Text == "" && OpenTextBox.Text == "" && ActionTextBox.Text == "")
            {
                EmptyWarn.Visible = true;
                return;
            }

            // Show the Preface confirmation window, and then continue after clicking OK
            new NoticeWindow().ShowDialog();

            // Create the file as a string
            var _out = "[autorun]\n";

            if (LabelTextBox.Text != "")
            {
                _out += "label=" + LabelTextBox.Text + "\n";
            }

            if (IconTextBox.Text != "")
            {
                _out += "icon=" + IconTextBox.Text + "\n";
            }

            if (!UFDCheckbox.Checked)
            {
                if (OpenTextBox.Text != "")
                {
                    _out += "open=" + OpenTextBox.Text + "\n";
                }

                if (ActionTextBox.Text != "")
                {
                    _out += "action=" + ActionTextBox.Text + "\n";
                }
            }

            // Generate, and save file
            try
            {
                // Create path variable, show dialog to set
                var path = "";
                if (FilePromptSA.ShowDialog() == DialogResult.OK)
                {
                    path = FilePromptSA.FileName;
                }

                // Deletes the file at path's location if it exists
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Generate a textfile to output, and save at path's location
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(_out);
                    fs.Write(info, 0, info.Length);
                }

                // Show the success window
                new SaveSuccessPrompt().ShowDialog();
                this.Close();
            }
            catch (Exception) { }
        }
    }
}
