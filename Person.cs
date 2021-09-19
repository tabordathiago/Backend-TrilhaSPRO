using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOne
{
    public class PersonName
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class PersonDocument
    {
        public string Type { get; set; }
        public string Value { get; set; }

    }

     public class PersonPhone
    {
        public string CountryCode { get; set; }
        public int AreaCode { get; set; }
        public string PhoneNumber { get; set; }

    }

     public class EmailAdress
    {
        public string Email { get; set; }
    }

    public class PostalAddress
    {
        public string AddressCountry { get; set; }
        public string AddressLocality { get; set; }
        public string AddressRegion { get; set; }
        public string PostalCode { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }

        public PersonName Name { get; set; } = new PersonName();

        public List<PersonDocument> Document { get; set; } = new List<PersonDocument>();

        public string Gender { get; set; }

        public DateTime Birth { get; set; } 

        public string Email { get; set; } 

        public PersonPhone Phone { get; set; } = new PersonPhone();

        public PostalAddress PostalAddress { get; set; } = new PostalAddress();
    }


}