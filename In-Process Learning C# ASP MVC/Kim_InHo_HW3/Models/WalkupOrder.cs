using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kim_InHo_HW3.Models
{
    public class WalkupOrder : Order
    {
        //Sales tax rate (8.5%)
        const Decimal SALES_TAX_RATE = 0.085m;

        //Customer’s Name with any value
        [Display(Name = "Customer Name:")]
        public string CustomerName { get; set; }

        //Subtotal * Sales tax rate
        [Display(Name = "Sales Tax:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal SalesTax { get; set; }

        /*Calls CalcSubtotals on base class
        Calculates SalesTax and Total*/
        public void CalcTotals()
        {
            base.CalcSubtotals();
            SalesTax = base.Subtotal * SALES_TAX_RATE;
            base.Total = base.Subtotal + SalesTax;
        }
    }
}
