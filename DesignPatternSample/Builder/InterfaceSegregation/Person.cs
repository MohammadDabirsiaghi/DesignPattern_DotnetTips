using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder.InterfaceSegregation
{
    class Person : IPerson
    {

        private string Name { get; }
        private string Surname { get; }
        private IContact PrimaryContact { get; set; }
        private IList<IContact> AllContacts { get; }

        public Person(string name, string surname, IContact primaryContact)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));
            if (string.IsNullOrEmpty(surname))
                throw new ArgumentException(nameof(surname));

            this.Name = name;
            this.Surname = surname;
            this.AllContacts = new List<IContact>();

            this.SetPrimaryContact(primaryContact);
        }

        public void SetPrimaryContact(IContact contact)
        {
            this.AddContact(contact);
            this.PrimaryContact = contact;
        }

        public void AddContact(IContact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            this.AllContacts.Add(contact);
        }
    }
}
