/*┌─────────────────────────────────────────────────────────────────────────────────────┐
  │                                   Jorge J. Pereda                                   │
  │                                Azure Cloud Developer                                │
  │                                    Jensen - 2023                                    │
  └─────────────────────────────────────────────────────────────────────────────────────┘*/

using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Gruppuppgift
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(List<Logger.LogEntry> logEntries)
        {
            InitializeComponent();

            dataGridView1.DataSource = logEntries;

            /*┌─────────────────────────┐
              │     Form properties     │
              └─────────────────────────┘*/
            LogFormProperties.SetFormProperties(this);

            /*┌───────────────────────────┐
              │     Set maximum width     │
              └───────────────────────────┘*/
            dataGridView1.MaximumSize = new System.Drawing.Size(570, dataGridView1.Height);

            


        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {

            /*┌───────────────────────────────────────────────────────────┐
              │     Customize the appearance or behavior of ErrorForm     │
              └───────────────────────────────────────────────────────────┘*/
            dataGridView1.Columns["timestamp"].Width = (int)(dataGridView1.Width * 0.3);
            dataGridView1.Columns["message"].Width = (int)(dataGridView1.Width * 0.7);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public ErrorForm(string logMessage)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(logMessage);
        }

    }
}
