using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuredPerson = db.Insurees.Where(x => x.Quote >= 0).ToList();
                var insurees = new List<InsuranceVM>();

                foreach(var person in insuredPerson)
                {
                    var insurer = new InsuranceVM();
                    insurer.FirstName = person.FirstName;
                    insurer.LastName = person.LastName;
                    insurer.EmailAddress = person.EmailAddress;
                    insurer.Quote = (int)person.Quote;
                    insurees.Add(insurer);
                }
                return View(insurees);
            }
            
        }
    }
}