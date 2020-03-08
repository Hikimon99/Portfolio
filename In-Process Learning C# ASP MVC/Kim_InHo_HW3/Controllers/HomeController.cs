//Author: In Ho Kim
//Date: 2-20-2020
//Assignment: Homework 3
//Description: Homework on catering and walkups that helps us introduce models in our code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kim_InHo_HW3.Models;

namespace Kim_InHo_HW3.Controllers
{
    public class HomeController : Controller
    {
        //Returns the Index view as default
        public IActionResult Index()
        {
            return View();
        }

        //Returns checkout catering if button for catering is clicked
        public IActionResult CheckoutCatering()
        {
            return View();
        }

        //Returns checkout walkup if button for walkup is clicked
        public IActionResult CheckoutWalkup()
        {
            return View();
        }

        //Checks validation for catering and returns catering total values and view
        public IActionResult CateringTotals(CateringOrder Cateringorder)
        {
            TryValidateModel(Cateringorder);

            if(ModelState.IsValid == false) //something is wrong
            {
                return View("CheckoutCatering", Cateringorder);
            }

            //sets the given customer type
            Cateringorder.Customertype = CustomerType.Catering;

            if (Cateringorder.PreferredCustomer)
            {
                Cateringorder._decDeliveryFee = 0m;
            }

            //calculates all preliminary prices and total
            Cateringorder.CalcTotals(Cateringorder._decDeliveryFee);

            //Move to catering totals
            return View("CateringTotals", Cateringorder);
        }

        //Checks validation for walkup and returns Walkup total values and view
        public IActionResult WalkupTotals(WalkupOrder Walkuporder)
        {
            TryValidateModel(Walkuporder);

            if (ModelState.IsValid == false) //something is wrong
            {
                return View("CheckoutWalkup", Walkuporder);
            }

            //sets the given customer type
            Walkuporder.Customertype = CustomerType.Walkup;

            //calculates all preliminary prices and total
            Walkuporder.CalcTotals();

            //Move to walkup totals
            return View("WalkupTotals", Walkuporder);
        }

    }
}