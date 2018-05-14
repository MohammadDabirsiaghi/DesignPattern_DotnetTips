using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder.InterfaceSegregation
{
    class PersonBuilder : IPersonBuilder
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private IContact PrimaryContact { get; set; }
        private IList<IContact> OtherContacts { get; } = new List<IContact>();

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));
            this.Name = name;
        }

        public void SetSurname(string surname)
        {
            if (string.IsNullOrEmpty(surname))
                throw new ArgumentException(nameof(surname));
            this.Surname = surname;
        }

        public void SetPrimaryContact(IContact primaryContact)
        {
            if (primaryContact == null)
                throw new ArgumentNullException(nameof(primaryContact));
            this.PrimaryContact = primaryContact;
        }

        public void AddContact(IContact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));
            this.OtherContacts.Add(contact);
        }

        public IPerson Build()
        {
            IPerson person = new Person(this.Name, this.Surname, this.PrimaryContact);

            foreach (IContact contact in this.OtherContacts)
                person.AddContact(contact);

            return person;
        }
    }
