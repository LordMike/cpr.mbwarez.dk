using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Web.Services;
using System.Linq;

namespace CPR
{
    /// <summary>
    /// Summary description for CPRService
    /// </summary>
    [WebService(Namespace = "http://cpr.mbwarez.dk/CPRService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class CPRService : WebService
    {
        public enum Gender
        {
            Male, Female
        }

        [WebMethod]
        public List<string> RetrieveCPR(DateTime date)
        {
            return GenerateCPRForDate(date).Select(s => s.ToString()).ToList();
        }

        [WebMethod]
        public List<string> RetrieveCPRGender(DateTime date, Gender gender)
        {
            Contract.Requires<ArgumentException>(Enum.IsDefined(typeof(Gender), gender));

            return GenerateCPRForDate(date).Where(s => (gender == Gender.Female && s.SecretDigits % 2 == 0) || (gender == Gender.Male && s.SecretDigits % 2 == 1)).Select(s => s.ToString()).ToList();
        }

        private List<CPRNumber> GenerateCPRForDate(DateTime date)
        {
            int rangeLow, rangeHigh;
            if ((date.Year / 100) % 2 == 0)
            {
                // Even century. For example: 18xx, 20xx, 22xx
                rangeLow = 5000;
                rangeHigh = 9999;
            }
            else
            {
                // Odd century. For example: 19xx, 21xx, 23xx
                rangeLow = 0;
                rangeHigh = 4999;
            }

            List<CPRNumber> res = new List<CPRNumber>();

            for (int i = rangeLow; i <= rangeHigh; i++)
            {
                CPRNumber c = new CPRNumber();
                c.Date = date;
                c.SecretDigits = i;

                if (CPRUtilities.CheckCPR(c))
                    res.Add(c);
            }

            return res;
        }
    }
}
