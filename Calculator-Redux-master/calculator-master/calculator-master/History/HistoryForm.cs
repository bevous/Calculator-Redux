using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History
{
    /// <summary>
    /// The history form.
    /// </summary>
    public partial class HistoryForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryForm"/> class.
        /// </summary>
        public HistoryForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The clear history button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            this.HistoryRichTextBox.Clear();

        }
    }
}
