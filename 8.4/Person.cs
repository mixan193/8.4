using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8._4
{
    internal class Person
    {
        public string name;
        public string street;
        public string houseNumber;
        public string flatNumber;
        public string mobilePhone;
        public string flatPhone;
        public Person(string name, string street, string houseNumber, string flatNumber, string mobilePhone, string flatPhone)
        {
            this.name = name;
            this.street = street;
            this.houseNumber = houseNumber;
            this.flatNumber = flatNumber;
            this.mobilePhone = mobilePhone;
            this.flatPhone = flatPhone;
        }

        public XElement SerializePerson()
        {
            XElement person = new XElement("Person");
            XAttribute personAttribute = new XAttribute("name", name);
            XElement address = new XElement("Address");
            XElement street = new XElement("Street");
            street.Value = this.street;
            XElement houseNumber = new XElement("HouseNumber");
            houseNumber.Value = this.houseNumber;
            XElement flatNumber = new XElement("FlatNumber");
            flatNumber.Value = this.flatNumber;
            XElement phones = new XElement("Phones");
            XElement mobilePhone = new XElement("MobilePhone");
            mobilePhone.Value = this.mobilePhone;
            XElement flatPhone = new XElement("FlatPhone");
            flatPhone.Value = this.flatPhone;
            address.Add(street, houseNumber, flatNumber);
            phones.Add(mobilePhone, flatPhone);
            person.Add(personAttribute, address, phones);
            return person;
        }
    }
}
