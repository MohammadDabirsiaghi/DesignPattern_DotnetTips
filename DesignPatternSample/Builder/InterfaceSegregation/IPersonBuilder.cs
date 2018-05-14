using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder.InterfaceSegregation
{
    interface IPersonBuilder
    {
        void SetName(string name);
        void SetSurname(string surname);
        void SetPrimaryContact(IContact primaryContact);
        void AddContact(IContact contact);
        IPerson Build();
    }
}
