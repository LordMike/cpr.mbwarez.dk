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
            return CPRUtilities.Generate(date).Select(s => s.ToString()).ToList();
        }

        [WebMethod]
        public List<string> RetrieveCPRGender(DateTime date, Gender gender)
        {
            Contract.Requires<ArgumentException>(Enum.IsDefined(typeof(Gender), gender));

            return CPRUtilities.Generate(date).Where(s => (gender == Gender.Female && s.SecretDigits % 2 == 0) || (gender == Gender.Male && s.SecretDigits % 2 == 1)).Select(s => s.ToString()).ToList();
        }
    }
}
