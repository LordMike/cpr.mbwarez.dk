using System;

namespace Web.Code
{
    public static class Localization
    {
        public static string GetString(Gender gender)
        {
            switch (gender)
            {
                case Gender.Either:
                    return "Ukendt";
                case Gender.Male:
                    return "Mand";
                case Gender.Female:
                    return "Kvinde";
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }
    }
}
