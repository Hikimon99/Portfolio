using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kim_InHo_HW3.Models
{
    public enum CustomerType
    {
        Catering, Walkup
    }
    public abstract class Order
    {
        //Price per taco ($3)
        const Decimal TACO_PRICE = 3m;
        //Price per sandwich ($5)
        const Decimal SANDWICH_PRICE = 5m;

        /*Stores whether the customer is a walkup or
        catering customer.*/
        [Display(Name = "Customer Type:")]
        public CustomerType Customertype { get;set;}

        //# of sandwiches requested by the customer
        private Int32 _intSandwiches;
        [Display(Name = "Number of Sandwiches:")]
        public Int32 NumberOfSandwiches 
        {
            get { return _intSandwiches; }
            set { _intSandwiches = value; }
        }

        //# of tacos requested by the customer
        private Int32 _intTacos;
        [Display(Name = "Number of Tacos:")]
        public Int32 NumberOfTacos
        {
            get { return _intTacos; }
            set { _intTacos = value; }
        }

        //# of sandwiches * price per sandwich
        [Display(Name = "Sandwich Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal SandwichSubtotal { get; set; }

        //# of tacos * price per taco
        [Display(Name = "Taco Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TacoSubtotal { get; set; }

        //TacoSubtotal + SandwichSubtotal
        [Display(Name = "Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Subtotal { get; set; }

        //Total items purchased
        [Display(Name = "Total Items:")]
        public Int32 TotalItems { get; set; }

        /*Subtotal + Tax (for walkup)
        Subtotal + Delivery Fee (for catering)*/
        private Decimal _decTotal;
        [Display(Name = "Total:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Total
        {
            get { return _decTotal; }
            set { _decTotal = value; }
        }

        //method to calculate subtotals and tax
        public void CalcSubtotals()
        {
            SandwichSubtotal = _intSandwiches * SANDWICH_PRICE;
            TacoSubtotal = _intTacos * TACO_PRICE;
            Subtotal = SandwichSubtotal + TacoSubtotal;
            TotalItems = _intSandwiches + _intTacos;
        }
    }
}
