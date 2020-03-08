using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kim_InHo_HW3.Models
{
    public class CateringOrder: Order
    {
        //Validations for 2-4 letters and writes error messages
        [Required]
        [MaxLength(4, ErrorMessage = "Code must be less than 4"), MinLength(2, ErrorMessage = "Code can't be less than 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters please")]
        public string CustomerCode { get; set; }

        //Validations for delivery fee max and min.
        [Required]
        public Decimal _decDeliveryFee;
        [Display(Name = "Delivery Fee:")]
        [Range(minimum: 0, maximum: 250, ErrorMessage = "Enter 0 or a positive number up to 250")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal DeliveryFee
        {
            get { return _decDeliveryFee; }
            set { _decDeliveryFee = value; }
        }

        //Property of Preferred Customer
        [Display(Name = "Is this a preferred customer:")]
        public Boolean PreferredCustomer { get; set; }

        //method to set delivery fee and calculate total
        public void CalcTotals(Decimal _decDeliveryFee)
        {
            base.CalcSubtotals();
            if (PreferredCustomer)
            {
                DeliveryFee = 0;
            }
            else { DeliveryFee = _decDeliveryFee; }
            base.Total = base.Subtotal + DeliveryFee;
        }
    }
}
