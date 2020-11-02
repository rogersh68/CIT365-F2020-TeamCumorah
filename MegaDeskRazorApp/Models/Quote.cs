using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazorApp.Models
{
    public class Quote
    {
        public int ID { get; set; }

        [Display(Name = "Customer Name")]
        public string customerName { get; set; }

        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public DateTime quoteDate { get; set; }

        [Display(Name = "Rush Days")]
        public int rushDays { get; set; }

        [Display(Name = "Desk Width")]
        public int deskWidth { get; set; }

        [Display(Name = "Desk Depth")]
        public int deskDepth { get; set; }

        [Display(Name = "Number of Drawers")]
        public int deskDrawer { get; set; }

        [Display (Name = "Desk Material")]
        public DesktopMaterial desktopMaterial { get; set; }

        [Display(Name = "Total Quote")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal totalQuote { get; set; }

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
