using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_2._0_TeamCumorah
{
    public class Quote
    {

        public string _customerName { get; set; }
        public int rushDays { get; set; }
        public string date { get; set; }
        public int deskWidth { get; set; }
        public int deskDepth { get; set; }
        public int deskDrawer { get; set; }
        public string deskMaterial { get; set; }
        public int totalQuote { get; set; }

        public Quote()
        {

        }
        //Quote constructor
        public Quote(string _customerName, int rushDays, string date, int deskWidth, int deskDepth, int deskDrawer, string deskMaterial, int totalQuote)
        {
            this._customerName = _customerName;
            this.rushDays = rushDays;
            this.date = date;
            this.deskWidth = deskWidth;
            this.deskDepth = deskDepth;
            this.deskDrawer = deskDrawer;
            this.deskMaterial = deskMaterial;
            this.totalQuote = totalQuote;

        }
    }
}
