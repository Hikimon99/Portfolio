//Author: In Ho Kim
//Date: 2/4/2020
//Assignment: Homework 1
//Description: Introduction to how model, views, controllers work

using Microsoft.AspNetCore.Mvc;
using System;
using Kim_InHo_HW1.Models;
using System.Linq;

namespace Kim_InHo_HW1.Controllers
{
    public class HomeController : Controller
    {
        //Shows the home page and introduction
        public ViewResult Index()
        {
            //Depending on the time, Good Morning or Afternoon is stated
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        //After clicking on link, the user is taken to the RSVP form
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        //With the filled out information, the HTTP posts the information to get the proper ansewr in guest response
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //only if the information was filled with the proper validations that thank is said.
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View(guestResponse);
            }
        }

        //List responses is only properly added if model view form is properly filled out
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}