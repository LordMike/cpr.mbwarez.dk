using System;
using System.Collections.Generic;
using Web.Code;

namespace Web.Models.Home
{
    public class HomeIndexModel
    {
        public List<Gender> Genders { get; set; }

        public List<CPRNumber> Numbers { get; set; }

        public Gender ShownGender { get; set; }

        public DateTime ShownDate { get; set; }

        public HomeIndexModel()
        {
            Genders = new List<Gender>();
            Numbers = new List<CPRNumber>();
        }
    }
}
