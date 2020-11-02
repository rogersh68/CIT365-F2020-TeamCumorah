using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazorApp.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string customerName { get; set; }
        [DataType(DataType.Date)]
        public DateTime quoteDate { get; set; }
        public int rushDays { get; set; }
        public int deskWidth { get; set; }
        public int deskDepth { get; set; }
        public int deskDrawer { get; set; }
        public DesktopMaterial desktopMaterial { get; set; }

        public enum DesktopMaterial
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }
    }
}
