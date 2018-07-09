namespace times_tables
{
    partial class MainForm
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
            this.equationTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equationTextBox
            // 
            this.equationTextBox.Location = new System.Drawing.Point(12, 12);
            this.equationTextBox.Name = "equationTextBox";
            this.equationTextBox.ReadOnly = true;
            this.equationTextBox.Size = new System.Drawing.Size(100, 20);
            this.equationTextBox.TabIndex = 0;
            this.equationTextBox.TabStop = false;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(118, 12);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 20);
            this.answerTextBox.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.checkButton.Location = new System.Drawing.Point(236, 10);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 54);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.equationTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Times Tables Tutor";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equationTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button checkButton;
    }
}

