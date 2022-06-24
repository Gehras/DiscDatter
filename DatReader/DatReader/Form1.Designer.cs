namespace DatReader
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
            this.addButton = new System.Windows.Forms.Button();
            this.toButton = new System.Windows.Forms.Button();
            this.combineButton = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.addPathLabel = new System.Windows.Forms.Label();
            this.toPathLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(127, 57);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 42);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Browse";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // toButton
            // 
            this.toButton.Location = new System.Drawing.Point(127, 127);
            this.toButton.Name = "toButton";
            this.toButton.Size = new System.Drawing.Size(101, 42);
            this.toButton.TabIndex = 1;
            this.toButton.Text = "Browse";
            this.toButton.UseVisualStyleBackColor = true;
            this.toButton.Click += new System.EventHandler(this.toButton_Click);
            // 
            // combineButton
            // 
            this.combineButton.Location = new System.Drawing.Point(405, 191);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(201, 53);
            this.combineButton.TabIndex = 2;
            this.combineButton.Text = "Combine!";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.combineButton_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(26, 68);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(95, 20);
            this.addLabel.TabIndex = 3;
            this.addLabel.Text = "Add this file:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(37, 138);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(84, 20);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To this file:";
            // 
            // addPathLabel
            // 
            this.addPathLabel.Location = new System.Drawing.Point(247, 68);
            this.addPathLabel.Name = "addPathLabel";
            this.addPathLabel.Size = new System.Drawing.Size(719, 55);
            this.addPathLabel.TabIndex = 5;
            // 
            // toPathLabel
            // 
            this.toPathLabel.Location = new System.Drawing.Point(247, 138);
            this.toPathLabel.Name = "toPathLabel";
            this.toPathLabel.Size = new System.Drawing.Size(719, 50);
            this.toPathLabel.TabIndex = 6;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Dump Files|*.txt;*.dat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 256);
            this.Controls.Add(this.toPathLabel);
            this.Controls.Add(this.addPathLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.toButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "DAT Enigma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button toButton;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label addPathLabel;
        private System.Windows.Forms.Label toPathLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

