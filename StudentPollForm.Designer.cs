namespace StudentPoll
{
    partial class StudentPollForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.surveyResultsButton = new System.Windows.Forms.Button();
            this.outputResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer result(1 - 10) and  press Enter";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(74, 47);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(190, 44);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 2;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // surveyResultsButton
            // 
            this.surveyResultsButton.Location = new System.Drawing.Point(116, 88);
            this.surveyResultsButton.Name = "surveyResultsButton";
            this.surveyResultsButton.Size = new System.Drawing.Size(120, 31);
            this.surveyResultsButton.TabIndex = 3;
            this.surveyResultsButton.Text = "View Survey Results";
            this.surveyResultsButton.UseVisualStyleBackColor = true;
            this.surveyResultsButton.Click += new System.EventHandler(this.surveyResultsButton_Click);
            // 
            // outputResultsRichTextBox
            // 
            this.outputResultsRichTextBox.Location = new System.Drawing.Point(45, 138);
            this.outputResultsRichTextBox.Name = "outputResultsRichTextBox";
            this.outputResultsRichTextBox.ReadOnly = true;
            this.outputResultsRichTextBox.Size = new System.Drawing.Size(267, 198);
            this.outputResultsRichTextBox.TabIndex = 4;
            this.outputResultsRichTextBox.Text = "";
            // 
            // StudentPollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 348);
            this.Controls.Add(this.outputResultsRichTextBox);
            this.Controls.Add(this.surveyResultsButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StudentPollForm";
            this.Text = "Student Poll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button surveyResultsButton;
        private System.Windows.Forms.RichTextBox outputResultsRichTextBox;
    }
}

