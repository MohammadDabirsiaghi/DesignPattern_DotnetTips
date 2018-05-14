using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder.InterfaceSegregation
{
    interface IPerson
    {
        void SetPrimaryContact(IContact primaryContact);
        void AddContact(IContact contact);
    }
}
