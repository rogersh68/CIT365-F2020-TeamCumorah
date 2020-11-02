using System;
using System.Drawing;
using System.Windows.Forms;

namespace MegaDesk_2._0_TeamCumorah
{
    public partial class ViewAllQuotes : Form
    {
        private DataGridView dgv = new DataGridView();
        public ViewAllQuotes()
        {
            InitializeComponent();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(dgv);

            dgv.ColumnCount = 5;

            dgv.Name = "quotesGridView";
            dgv.Location = new Point(8, 8);
            dgv.Size = new Size(550, 400);

            dgv.Columns[0].Name = "Customer Name";
            dgv.Columns[1].Name = "Date";
            dgv.Columns[2].Name = "Material";
            dgv.Columns[3].Name = "Rush Days";
            dgv.Columns[4].Name = "Price";
        }

        private void PopulateDataGridView()
        {
            foreach (Quote q in QuotesList.quotes)
            {
                string[] row = { q._customerName, q.date, q.deskMaterial, q.rushDays.ToString(), q.totalQuote.ToString("C2")};
                dgv.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the form
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
