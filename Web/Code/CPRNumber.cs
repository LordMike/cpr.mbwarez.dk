using System;

namespace Web.Code
{
    // ReSharper disable once InconsistentNaming
    public class CPRNumber
    {
        public DateTime Date { get; set; }
        public int SecretDigits { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format("{0:ddMMyy}-{1:0000}", Date, SecretDigits);
        }
    }
}