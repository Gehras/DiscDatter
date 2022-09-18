namespace DiscDatter
{
    partial class Form1
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
            this.submissionButton = new System.Windows.Forms.Button();
            this.datButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPathLabel = new System.Windows.Forms.Label();
            this.datPathLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // submissionButton
            // 
            this.submissionButton.Location = new System.Drawing.Point(39, 61);
            this.submissionButton.Name = "submissionButton";
            this.submissionButton.Size = new System.Drawing.Size(134, 52);
            this.submissionButton.TabIndex = 0;
            this.submissionButton.Text = "Browse";
            this.submissionButton.UseVisualStyleBackColor = true;
            this.submissionButton.Click += new System.EventHandler(this.submissionButton_Click);
            // 
            // datButton
            // 
            this.datButton.Location = new System.Drawing.Point(295, 61);
            this.datButton.Name = "datButton";
            this.datButton.Size = new System.Drawing.Size(134, 52);
            this.datButton.TabIndex = 1;
            this.datButton.Text = "Browse";
            this.datButton.UseVisualStyleBackColor = true;
            this.datButton.Click += new System.EventHandler(this.datButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Specify !submissionInfo.txt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Specify .dat";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(39, 265);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(390, 37);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "All Dump Files|*.txt;*.dat";
            // 
            // txtPathLabel
            // 
            this.txtPathLabel.Location = new System.Drawing.Point(35, 131);
            this.txtPathLabel.Name = "txtPathLabel";
            this.txtPathLabel.Size = new System.Drawing.Size(394, 54);
            this.txtPathLabel.TabIndex = 5;
            this.txtPathLabel.Text = "!submissionInfo.txt location: ";
            // 
            // datPathLabel
            // 
            this.datPathLabel.Location = new System.Drawing.Point(35, 200);
            this.datPathLabel.Name = "datPathLabel";
            this.datPathLabel.Size = new System.Drawing.Size(394, 62);
            this.datPathLabel.TabIndex = 6;
            this.datPathLabel.Text = ".dat location:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 320);
            this.Controls.Add(this.datPathLabel);
            this.Controls.Add(this.txtPathLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datButton);
            this.Controls.Add(this.submissionButton);
            this.Name = "Form1";
            this.Text = "DiscDatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submissionButton;
        private System.Windows.Forms.Button datButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label txtPathLabel;
        private System.Windows.Forms.Label datPathLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

