using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Web.Code;
using Web.Models.Home;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string date = null, Gender gender = Gender.Either)
        {
            HomeIndexModel model = new HomeIndexModel();

            model.Genders.Add(Gender.Either);
            model.Genders.Add(Gender.Male);
            model.Genders.Add(Gender.Female);

            model.ShownGender = gender;

            model.ShownDate = DateTime.Today;

            DateTime result;
            if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out result))
            {
                model.ShownDate = result;
                
                IEnumerable<CPRNumber> generator = CPRUtilities.Generate(result);

                if (gender != Gender.Either)
                    generator = generator.Where(s => s.Gender == gender);

                model.Numbers.AddRange(generator);
            }

            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
