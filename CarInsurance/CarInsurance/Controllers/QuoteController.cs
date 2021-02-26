using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnotherInsurance.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Apply(string firstName, string lastName, string emailAddress,
                             string dateOfBirth, string carYear, string carMake, string carModel,
                             string dui, string tickets, string coverage, string total)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) ||
                string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(dui) || string.IsNullOrEmpty(tickets) || string.IsNullOrEmpty(coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (AnotherInsuranceEntities db = new AnotherInsuranceEntities())
                {
                    var quote = new Applicant();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.DateOfBirth = dateOfBirth;
                    quote.CarYear = carYear;
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.DUI = dui;
                    quote.SpeedingTickets = tickets;
                    quote.CoverageType = coverage;
                    quote.Total = getTotal(dateOfBirth, carYear, carMake, carModel, dui, tickets, coverage);

                    db.Applicants.Add(quote);
                    db.SaveChanges();

                    ViewData["quote.Total"] = quote.Total;
                    return View("Index");
                }
            }
        }

        public string getTotal(string dateOfBirth, string carYear, string carMake, string carModel,
                                  string dui, string tickets, string coverage)
        {
            using (AnotherInsuranceEntities data = new AnotherInsuranceEntities())
            {
                decimal totalQuote = 50.00m;

                // Quote based on Age
                totalQuote = (DateTime.Now.Year - (Convert.ToDateTime(dateOfBirth)).Year < 25) ? totalQuote + 25 : totalQuote;
                totalQuote = (DateTime.Now.Year - (Convert.ToDateTime(dateOfBirth)).Year < 18) ? totalQuote + 100 : totalQuote;
                totalQuote = (DateTime.Now.Year - (Convert.ToDateTime(dateOfBirth)).Year > 100) ? totalQuote + 25 : totalQuote;

                // Quote based on Car
                totalQuote = (Convert.ToInt32(carYear) < 2000) ? totalQuote + 25 : totalQuote;
                totalQuote = (Convert.ToInt32(carYear) > 2015) ? totalQuote + 25 : totalQuote;
                totalQuote = (carMake.ToLower() == "porsche") ? totalQuote + 25 : totalQuote;
                totalQuote = (carModel.ToLower() == "911 carrera") ? totalQuote + 25 : totalQuote;

                // Tickets and DUI's
                totalQuote = totalQuote + (Convert.ToInt32(tickets) * 10);
                totalQuote = (dui.ToLower() == "yes") ? (totalQuote + (totalQuote / 4)) : totalQuote;

                // Coverage
                totalQuote = (coverage.ToLower() == "full") ? (totalQuote + (totalQuote / 2)) : totalQuote;

                return Convert.ToString(totalQuote);
            }
        }
    }
}

}