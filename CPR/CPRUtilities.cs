using System;
using System.Diagnostics.Contracts;

namespace CPR
{
    public static class CPRUtilities
    {
        public static readonly int[] Factors = new[] { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

        public static bool CheckCPR(int[] input)
        {
            Contract.Requires<ArgumentNullException>(input != null);
            Contract.Requires<InvalidOperationException>(input.Length == Factors.Length);

            int sum = 0;
            for (int x = 0; x < Factors.Length; x++)
            {
                sum += input[x] * Factors[x];
            }

            return sum % 11 == 0;
        }

        public static bool CheckCPR(CPRNumber cpr)
        {
            Contract.Requires<ArgumentNullException>(cpr != null);

            int[] input = new[]
                              {
                                  cpr.Date.Day/10, cpr.Date.Day%10, cpr.Date.Month/10, cpr.Date.Month%10,
                                  (cpr.Date.Year/10)%10, cpr.Date.Year%10,
                                  (cpr.SecretDigits/1000)%10, (cpr.SecretDigits/100)%10, (cpr.SecretDigits/10)%10,
                                  cpr.SecretDigits%10
                              };

            Contract.Assert(input.Length == Factors.Length);

            int sum = 0;
            for (int x = 0; x < Factors.Length; x++)
            {
                sum += input[x] * Factors[x];
            }

            return sum % 11 == 0;
        }
    }

    public class CPRNumber
    {
        public DateTime Date { get; set; }
        public int SecretDigits { get; set; }

        public override string ToString()
        {
            return string.Format("{0:ddMMyy}-{1:0000}", Date, SecretDigits);
        }
    }
}