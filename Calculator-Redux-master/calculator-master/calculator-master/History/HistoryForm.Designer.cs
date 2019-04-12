namespace History
{
    partial class HistoryForm
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
            this.ClearHistoryButton = new System.Windows.Forms.Button();
            this.HistoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ClearHistoryButton
            // 
            this.ClearHistoryButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ClearHistoryButton.Location = new System.Drawing.Point(12, 12);
            this.ClearHistoryButton.Name = "ClearHistoryButton";
            this.ClearHistoryButton.Size = new System.Drawing.Size(275, 66);
            this.ClearHistoryButton.TabIndex = 0;
            this.ClearHistoryButton.Text = "Clear History";
            this.ClearHistoryButton.UseVisualStyleBackColor = true;
            this.ClearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
            // 
            // HistoryRichTextBox
            // 
            this.HistoryRichTextBox.Location = new System.Drawing.Point(12, 84);
            this.HistoryRichTextBox.Name = "HistoryRichTextBox";
            this.HistoryRichTextBox.Size = new System.Drawing.Size(275, 354);
            this.HistoryRichTextBox.TabIndex = 1;
            this.HistoryRichTextBox.Text = "";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 450);
            this.Controls.Add(this.HistoryRichTextBox);
            this.Controls.Add(this.ClearHistoryButton);
            this.Name = "HistoryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClearHistoryButton;
        private System.Windows.Forms.RichTextBox HistoryRichTextBox;
    }
}

