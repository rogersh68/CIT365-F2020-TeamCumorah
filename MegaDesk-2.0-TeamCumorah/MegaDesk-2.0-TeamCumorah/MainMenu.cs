using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using System.Text;

namespace MegaDesk_2._0_TeamCumorah
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //read the quotes.json file
            read();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
            Hide();
        }

        private void btnViewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show(this);
            Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*********************************
        *  void read
        * reads in the quotes.json file and fills a Quote List object with the parsed json
        * ******************************/
        public static void read()
        {
            try
            {   //gets the directory path for the quotes.json file
                string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                dir = dir.Remove(dir.IndexOf("\\bin\\Debug"));
                //reads in the file
                using (StreamReader r = new StreamReader(dir + @"\quotes.json"))
                {
                    //read
                    string json = r.ReadToEnd();
                    //parse json into a List of Quotes within QuotesList
                    List<Quote> quotes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Quote>>(json);
                    //check if file is blank
                    if(quotes == null)
                    {
                        //create a new Quote within the list and set the QuotesList.quotes
                        quotes = new List<Quote>();
                        QuotesList.quotes = quotes;
                    }
                    else
                    {   //set the QuotesList.quotes
                        QuotesList.quotes = quotes;
                    }

                }
            }
            catch (Exception e)
            {
                /* cant create file due to permissions
                //if it cannot find a file, create it instead
                string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                dir = dir.Remove(dir.IndexOf("\\bin\\Debug"));
                using (FileStream fs = File.Create(@"\quotes.json"))
                 {
                     byte[] info = new UTF8Encoding(true).GetBytes("[]");
                     fs.Write(info, 0, info.Length);
                 }
                 QuotesList.quotes = new List<Quote>();*/
                Console.WriteLine("ERROR: " + e);
            }
        }

        /*********************************
        * void write
        * takes a string (_customerName), int (rushDays), string (date), int (deskWidth), int (deskDepth), int(deskDrawer), and string (deskMaterial) as parameters
        * writes the full, updated object list to the quotes.json file
        * ******************************/
        public static void write(string _customerName, int rushDays, string date, int deskWidth, int deskDepth, int deskDrawer, string deskMaterial)
        {
            //creates a new Quote with the parameters provided
            Quote quote = new Quote(_customerName, rushDays, date, deskWidth, deskDepth, deskDrawer, deskMaterial);
            //add the new Quote to the List of Quotes in QuotesList
            QuotesList.quotes.Add(quote);
            //Convert the List to json
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(QuotesList.quotes.ToArray());
            //gets the directory path for the quotes.json file
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            dir = dir.Remove(dir.IndexOf("\\bin\\Debug"));
            //write to the file
            System.IO.File.WriteAllText(dir + @"\quotes.json", json);
        }
    }
}
