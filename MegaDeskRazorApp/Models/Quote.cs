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
        [Required]
        public string customerName { get; set; }

        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]

        public DateTime quoteDate { get; set; }

        [Display(Name = "Rush Days")]
        [Range(0, 14)]
        public int rushDays { get; set; }

        [Display(Name = "Desk Width")]
        [Range(24, 96)]
        public int deskWidth { get; set; }

        [Display(Name = "Desk Depth")]
        [Range(12, 44)]
        public int deskDepth { get; set; }

        [Display(Name = "Number of Drawers")]
        [Range(0, 7)]
        public int deskDrawer { get; set; }

        [Display (Name = "Desk Material")]
        [Required]
        public DesktopMaterial desktopMaterial { get; set; }

        [Display(Name = "Total Quote")]
        [DataType(DataType.Currency)]
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
        public void calcTotalQuote()
        {
            int area = deskWidth* deskDepth;
            int drawerAmount = deskDrawer * 50;
            int rushAmount = calcRushPrice(area, rushDays);

            totalQuote = 200 + area + drawerAmount + (int)desktopMaterial + rushAmount;
        }
        public int calcRushPrice(int area, int rushDays)
        {
            switch (rushDays)
            {
                case 3:
                    if(area < 1000)
                    {
                        return 60;
                    }
                    else if (area > 2000)
                    {
                        return 80;
                    }
                    else
                    {
                        return 70;
                    }
                case 5:
                    if(area < 1000)
                    {
                        return 40;
                    }
                    else if (area > 2000)
                    {
                        return 60;
                    }
                    else
                    {
                        return 50;
                    }
                case 7:
                    if(area < 1000)
                    {
                        return 30;
                    }
                    else if (area > 2000)
                    {
                        return 40;
                    }
                    else
                    {
                        return 35;
                    }
                default:
                    return 0;
            }
        }
        
    }
}
