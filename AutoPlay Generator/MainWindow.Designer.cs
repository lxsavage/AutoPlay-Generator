namespace AutoPlay_Generator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.UFDCheckbox = new System.Windows.Forms.CheckBox();
            this.MetadataFormPanel = new System.Windows.Forms.Panel();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.IconLabel = new System.Windows.Forms.Label();
            this.LoadFileLI = new System.Windows.Forms.Button();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.IconTextBox = new System.Windows.Forms.TextBox();
            this.LabelTextBox = new System.Windows.Forms.TextBox();
            this.FilePromptLI = new System.Windows.Forms.OpenFileDialog();
            this.FilePromptLP = new System.Windows.Forms.OpenFileDialog();
            this.AutoRunGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.OpenTextBox = new System.Windows.Forms.TextBox();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.ActionTextBox = new System.Windows.Forms.TextBox();
            this.LoadFileLP = new System.Windows.Forms.Button();
            this.FilePromptSA = new System.Windows.Forms.SaveFileDialog();
            this.EmptyWarn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.MetadataFormPanel.SuspendLayout();
            this.DisplayGroupBox.SuspendLayout();
            this.AutoRunGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UFDCheckbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MetadataFormPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GenerateButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(234, 231);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(1, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(221, 36);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate and Save...";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // UFDCheckbox
            // 
            this.UFDCheckbox.AutoSize = true;
            this.UFDCheckbox.Checked = true;
            this.UFDCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UFDCheckbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UFDCheckbox.Location = new System.Drawing.Point(3, 249);
            this.UFDCheckbox.Name = "UFDCheckbox";
            this.UFDCheckbox.Size = new System.Drawing.Size(225, 21);
            this.UFDCheckbox.TabIndex = 1;
            this.UFDCheckbox.Text = "Drive is UFD (Flash Drive)";
            this.UFDCheckbox.UseVisualStyleBackColor = true;
            this.UFDCheckbox.CheckedChanged += new System.EventHandler(this.UFDCheckbox_CheckedChanged);
            // 
            // MetadataFormPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.MetadataFormPanel, 2);
            this.MetadataFormPanel.Controls.Add(this.AutoRunGroupBox);
            this.MetadataFormPanel.Controls.Add(this.DisplayGroupBox);
            this.MetadataFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetadataFormPanel.Location = new System.Drawing.Point(3, 3);
            this.MetadataFormPanel.Name = "MetadataFormPanel";
            this.MetadataFormPanel.Size = new System.Drawing.Size(456, 222);
            this.MetadataFormPanel.TabIndex = 2;
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.Controls.Add(this.EmptyWarn);
            this.DisplayGroupBox.Controls.Add(this.IconLabel);
            this.DisplayGroupBox.Controls.Add(this.LoadFileLI);
            this.DisplayGroupBox.Controls.Add(this.LabelLabel);
            this.DisplayGroupBox.Controls.Add(this.IconTextBox);
            this.DisplayGroupBox.Controls.Add(this.LabelTextBox);
            this.DisplayGroupBox.Location = new System.Drawing.Point(9, 9);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(435, 101);
            this.DisplayGroupBox.TabIndex = 3;
            this.DisplayGroupBox.TabStop = false;
            this.DisplayGroupBox.Text = "Display";
            // 
            // IconLabel
            // 
            this.IconLabel.AutoSize = true;
            this.IconLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IconLabel.Location = new System.Drawing.Point(30, 67);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(38, 17);
            this.IconLabel.TabIndex = 3;
            this.IconLabel.Text = "Icon:";
            // 
            // LoadFileLI
            // 
            this.LoadFileLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LoadFileLI.Location = new System.Drawing.Point(291, 64);
            this.LoadFileLI.Name = "LoadFileLI";
            this.LoadFileLI.Size = new System.Drawing.Size(95, 23);
            this.LoadFileLI.TabIndex = 3;
            this.LoadFileLI.Text = "Browse...";
            this.LoadFileLI.UseVisualStyleBackColor = true;
            this.LoadFileLI.Click += new System.EventHandler(this.LoadFileLI_Click);
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelLabel.Location = new System.Drawing.Point(19, 31);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(49, 17);
            this.LabelLabel.TabIndex = 2;
            this.LabelLabel.Text = "Name:";
            // 
            // IconTextBox
            // 
            this.IconTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IconTextBox.Location = new System.Drawing.Point(74, 64);
            this.IconTextBox.Name = "IconTextBox";
            this.IconTextBox.Size = new System.Drawing.Size(211, 23);
            this.IconTextBox.TabIndex = 1;
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelTextBox.Location = new System.Drawing.Point(74, 28);
            this.LabelTextBox.MaxLength = 32;
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.Size = new System.Drawing.Size(312, 23);
            this.LabelTextBox.TabIndex = 0;
            // 
            // FilePromptLI
            // 
            this.FilePromptLI.FileName = "FilePromptLI";
            this.FilePromptLI.Filter = "Windows Icons (*.ico)|*.ico";
            this.FilePromptLI.Title = "Choose Icon Location";
            // 
            // FilePromptLP
            // 
            this.FilePromptLP.FileName = "FilePromptLP";
            this.FilePromptLP.Filter = "Executable Files (*.exe)|*.exe";
            this.FilePromptLP.Title = "Choose Program Location";
            // 
            // AutoRunGroupBox
            // 
            this.AutoRunGroupBox.Controls.Add(this.LoadFileLP);
            this.AutoRunGroupBox.Controls.Add(this.ActionTextBox);
            this.AutoRunGroupBox.Controls.Add(this.ActionLabel);
            this.AutoRunGroupBox.Controls.Add(this.OpenTextBox);
            this.AutoRunGroupBox.Controls.Add(this.OpenLabel);
            this.AutoRunGroupBox.Enabled = false;
            this.AutoRunGroupBox.Location = new System.Drawing.Point(9, 116);
            this.AutoRunGroupBox.Name = "AutoRunGroupBox";
            this.AutoRunGroupBox.Size = new System.Drawing.Size(435, 97);
            this.AutoRunGroupBox.TabIndex = 4;
            this.AutoRunGroupBox.TabStop = false;
            this.AutoRunGroupBox.Text = "AutoRun Program";
            // 
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OpenLabel.Location = new System.Drawing.Point(6, 32);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(66, 17);
            this.OpenLabel.TabIndex = 0;
            this.OpenLabel.Text = "Program:";
            // 
            // OpenTextBox
            // 
            this.OpenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OpenTextBox.Location = new System.Drawing.Point(74, 29);
            this.OpenTextBox.Name = "OpenTextBox";
            this.OpenTextBox.Size = new System.Drawing.Size(211, 23);
            this.OpenTextBox.TabIndex = 1;
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ActionLabel.Location = new System.Drawing.Point(15, 65);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(57, 17);
            this.ActionLabel.TabIndex = 2;
            this.ActionLabel.Text = "Prompt:";
            // 
            // ActionTextBox
            // 
            this.ActionTextBox.Location = new System.Drawing.Point(74, 62);
            this.ActionTextBox.Name = "ActionTextBox";
            this.ActionTextBox.Size = new System.Drawing.Size(312, 22);
            this.ActionTextBox.TabIndex = 3;
            // 
            // LoadFileLP
            // 
            this.LoadFileLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LoadFileLP.Location = new System.Drawing.Point(291, 29);
            this.LoadFileLP.Name = "LoadFileLP";
            this.LoadFileLP.Size = new System.Drawing.Size(95, 23);
            this.LoadFileLP.TabIndex = 4;
            this.LoadFileLP.Text = "Browse...";
            this.LoadFileLP.UseVisualStyleBackColor = true;
            this.LoadFileLP.Click += new System.EventHandler(this.LoadFileLP_Click);
            // 
            // FilePromptSA
            // 
            this.FilePromptSA.FileName = "autorun.inf";
            this.FilePromptSA.Title = "Choose Root of Drive";
            // 
            // EmptyWarn
            // 
            this.EmptyWarn.AutoSize = true;
            this.EmptyWarn.ForeColor = System.Drawing.Color.Maroon;
            this.EmptyWarn.Location = new System.Drawing.Point(211, -3);
            this.EmptyWarn.Name = "EmptyWarn";
            this.EmptyWarn.Size = new System.Drawing.Size(224, 17);
            this.EmptyWarn.TabIndex = 1;
            this.EmptyWarn.Text = "At least one field must be filled out";
            this.EmptyWarn.Visible = false;
            // 
            // Main
            // 
            this.AcceptButton = this.GenerateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "AutoPlay Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MetadataFormPanel.ResumeLayout(false);
            this.DisplayGroupBox.ResumeLayout(false);
            this.DisplayGroupBox.PerformLayout();
            this.AutoRunGroupBox.ResumeLayout(false);
            this.AutoRunGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox UFDCheckbox;
        private System.Windows.Forms.OpenFileDialog FilePromptLI;
        private System.Windows.Forms.OpenFileDialog FilePromptLP;
        private System.Windows.Forms.Panel MetadataFormPanel;
        private System.Windows.Forms.GroupBox DisplayGroupBox;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.TextBox IconTextBox;
        private System.Windows.Forms.TextBox LabelTextBox;
        private System.Windows.Forms.Button LoadFileLI;
        private System.Windows.Forms.GroupBox AutoRunGroupBox;
        private System.Windows.Forms.TextBox OpenTextBox;
        private System.Windows.Forms.Label OpenLabel;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.TextBox ActionTextBox;
        private System.Windows.Forms.Button LoadFileLP;
        private System.Windows.Forms.SaveFileDialog FilePromptSA;
        private System.Windows.Forms.Label EmptyWarn;
    }
}

