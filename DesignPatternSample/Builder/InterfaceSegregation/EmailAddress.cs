using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder.InterfaceSegregation
{
    class EmailAddress : IContact
    {
        private string Address { get; }

        public EmailAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentException(nameof(address));

            this.Address = address;
        }
    }
}
