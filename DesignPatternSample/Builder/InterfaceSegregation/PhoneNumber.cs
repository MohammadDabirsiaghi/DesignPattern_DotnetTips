using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder.InterfaceSegregation
{
    class PhoneNumber : IContact
    {

        private string AreaCode { get; }
        private string Number { get; }

        public PhoneNumber(string areaCode, string number)
        {

            if (string.IsNullOrEmpty(areaCode))
                throw new ArgumentException(nameof(areaCode));
            if (string.IsNullOrEmpty(number))
                throw new ArgumentException(nameof(number));

            this.AreaCode = areaCode;
            this.Number = number;
        }
    }
}
