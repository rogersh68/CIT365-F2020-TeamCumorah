using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lvQuoteList.Clear(); 
            lvQuoteList.Items.Clear();
            lvQuoteList.View = View.Details;

            try
            { 

            string deskMaterials = cbMaterials.SelectedItem.ToString();

            lvQuoteList.Columns.Add("#", 30, HorizontalAlignment.Left);
            lvQuoteList.Columns.Add("Client Name", 200, HorizontalAlignment.Left);
            lvQuoteList.Columns.Add("Date", 180, HorizontalAlignment.Left);
            lvQuoteList.Columns.Add("Width", 70, HorizontalAlignment.Left);
            lvQuoteList.Columns.Add("Depth", 70, HorizontalAlignment.Left);
            lvQuoteList.Columns.Add("Drawers", 70, HorizontalAlignment.Left);
            lvQuoteList.Columns.Add("Material", 100, HorizontalAlignment.Left);
            lvQuoteList.Columns.Add("Rush Days", 70, HorizontalAlignment.Left);
            lvQuoteList.Columns.Add("Total Amount", 150, HorizontalAlignment.Left);

            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            dir = dir.Remove(dir.IndexOf("\\bin\\Debug"));
            //reads in the file
            using (StreamReader r = new StreamReader(dir + @"\quotes.json"))
            {
                int rowCount = 0;

                    while (!r.EndOfStream)
                    {
                        //read
                        string json = r.ReadToEnd();
                        //parse json into a List of Quotes within QuotesList
                        List<Quote> quotes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Quote>>(json);

                        foreach (Quote quote in quotes)
                        {
                            if (quote.deskMaterial == deskMaterials)
                            {
                                rowCount++;
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
