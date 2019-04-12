using System;
using System.Windows.Forms;

namespace calculator_redux
{
    public partial class HistoryForm : Form
    {
        public HistoryForm(string history)
        {
            this.InitializeComponent();
            this.HistoryRichTextBox.Text = history;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.HistoryRichTextBox.Clear();
        }
    }
}
