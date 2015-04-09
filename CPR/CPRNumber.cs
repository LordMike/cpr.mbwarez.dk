using System;

namespace CPR
{
    public class CprNumber
    {
        public DateTime Date { get; set; }
        public int SecretDigits { get; set; }

        public CPRService.Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format("{0:ddMMyy}-{1:0000}", Date, SecretDigits);
        }
    }
}