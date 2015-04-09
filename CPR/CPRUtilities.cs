using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace CPR
{
    public static class CPRUtilities
    {
        public static readonly int[] Factors = new[] { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

        public static bool CheckCPR(int[] input)
        {
            int sum = 0;
            for (int x = 0; x < Factors.Length; x++)
            {
                sum += input[x] * Factors[x];
            }

            return sum % 11 == 0;
        }

        public static bool CheckCPR(CprNumber cpr)
        {
            int[] input =
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

        public static IEnumerable<CprNumber> Generate(DateTime date)
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

            for (int i = rangeLow; i <= rangeHigh; i++)
            {
                CprNumber c = new CprNumber();
                c.Date = date;
                c.SecretDigits = i;
                c.Gender = c.SecretDigits % 2 == 0 ? CPRService.Gender.Female : CPRService.Gender.Male;

                if (CheckCPR(c))
                    yield return c;
            }
        }

    }
}