namespace AutoPlay_Generator
{
    partial class NoticeWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PromptLabel = new System.Windows.Forms.Label();
            this.WarningLine3 = new System.Windows.Forms.Label();
            this.WarningLine2 = new System.Windows.Forms.Label();
            this.WarningLine1 = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 195);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PromptLabel);
            this.panel1.Controls.Add(this.WarningLine3);
            this.panel1.Controls.Add(this.WarningLine2);
            this.panel1.Controls.Add(this.WarningLine1);
            this.panel1.Controls.Add(this.HeaderLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 154);
            this.panel1.TabIndex = 1;
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.Location = new System.Drawing.Point(9, 128);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(146, 17);
            this.PromptLabel.TabIndex = 1;
            this.PromptLabel.Text = "Press OK to continue.";
            // 
            // WarningLine3
            // 
            this.WarningLine3.AutoSize = true;
            this.WarningLine3.Location = new System.Drawing.Point(9, 69);
            this.WarningLine3.Name = "WarningLine3";
            this.WarningLine3.Size = new System.Drawing.Size(382, 17);
            this.WarningLine3.TabIndex = 4;
            this.WarningLine3.Text = "or application (?) exists in the root as described in the form.";
            // 
            // WarningLine2
            // 
            this.WarningLine2.AutoSize = true;
            this.WarningLine2.Location = new System.Drawing.Point(9, 52);
            this.WarningLine2.Name = "WarningLine2";
            this.WarningLine2.Size = new System.Drawing.Size(474, 17);
            this.WarningLine2.TabIndex = 3;
            this.WarningLine2.Text = "root of the drive, as if it isn\'t it won\'t work. Also, make sure the set icon (?)" +
    " ";
            // 
            // WarningLine1
            // 
            this.WarningLine1.AutoSize = true;
            this.WarningLine1.Location = new System.Drawing.Point(9, 35);
            this.WarningLine1.Name = "WarningLine1";
            this.WarningLine1.Size = new System.Drawing.Size(464, 17);
            this.WarningLine1.TabIndex = 2;
            this.WarningLine1.Text = "The outputted file must be saved as \"autorun.inf\"; make SURE it is in the";
            this.WarningLine1.Click += new System.EventHandler(this.WarningLine1_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.HeaderLabel.Location = new System.Drawing.Point(9, 6);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(313, 17);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Important Information on Saving an AutoRun File";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.OKButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(485, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKButton.Location = new System.Drawing.Point(407, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 26);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NoticeWindow
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 195);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoticeWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Important";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WarningLine3;
        private System.Windows.Forms.Label WarningLine2;
        private System.Windows.Forms.Label WarningLine1;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label PromptLabel;
    }
}