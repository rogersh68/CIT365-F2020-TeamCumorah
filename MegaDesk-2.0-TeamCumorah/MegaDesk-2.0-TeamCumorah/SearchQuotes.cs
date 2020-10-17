using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_2._0_TeamCumorah
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This binds data to the material combobox from an enumerator
        /// </summary>
        public void BindMaterial()
        {
            List<Desk.DesktopMaterial> desktopMaterials = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            cbMaterials.DataSource = desktopMaterials;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the form
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Clear the ListView and its contents
            lvQuoteList.Clear(); 
            lvQuoteList.Items.Clear();

            // Change the View of the ListView
            lvQuoteList.View = View.Details;

            try
            { 
                // Get the text value of the Materials combobox
                string deskMaterials = cbMaterials.SelectedItem.ToString();

                // Create ListView Columns and Column properties
                lvQuoteList.Columns.Add("#", 30, HorizontalAlignment.Left);
                lvQuoteList.Columns.Add("Client Name", 180, HorizontalAlignment.Left);
                lvQuoteList.Columns.Add("Date", 170, HorizontalAlignment.Left);
                lvQuoteList.Columns.Add("Width", 70, HorizontalAlignment.Left);
                lvQuoteList.Columns.Add("Depth", 70, HorizontalAlignment.Left);
                lvQuoteList.Columns.Add("Drawers", 70, HorizontalAlignment.Left);
                lvQuoteList.Columns.Add("Material", 100, HorizontalAlignment.Left);
                lvQuoteList.Columns.Add("Rush Days", 120, HorizontalAlignment.Left);
                lvQuoteList.Columns.Add("Total Amount", 150, HorizontalAlignment.Left);

                // Add a row counter
                int rowCount = 0;

                foreach (Quote quote in QuotesList.quotes)
                {
                    if (quote.deskMaterial == deskMaterials)
                    {
                        // Increment the row counter
                        rowCount++;
                        // Add ListView Items
                        lvQuoteList.Items.Add(new ListViewItem(new[]
                        {
                            rowCount.ToString(),
                            quote._customerName,
                            quote.date,
                            quote.deskWidth.ToString(),
                            quote.deskDepth.ToString(),
                            quote.deskDrawer.ToString(),
                            quote.deskMaterial,
                            quote.rushDays.ToString(),
                            quote.totalQuote.ToString("C2")
                        }));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error populating the report: " + "\n\n" + ex.Message);
            }
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            BindMaterial();
        }
    }
}
