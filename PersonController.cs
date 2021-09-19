using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOne
{
    [Route("person")]
    public class PersonController : ControllerBase
    {
        public static List<Person> PersonList = new List<Person>();

        [HttpGet("get")]
        public List<Person> Get()
        {
            return PersonList;
        }

        [HttpGet("getbyid")]
        public Person Get([FromQuery]int id)
        {
            return PersonList.Where(x => x.Id == id).First();
        }

        [HttpPost("upsert")]
        public Person Upsert([FromBody]Person person)
        {
            if (person.Id == 0)
            {
                person.Id = PersonList.Count + 1;
                PersonList.Add(person);
            }
            else
            {
                var existPerson = PersonList.Where(x => x.Id == person.Id).First();

                existPerson.Name = person.Name;
                existPerson.PostalAddress = person.PostalAddress;
                existPerson.Birth = person.Birth;
                existPerson.Gender = person.Gender;
            }
            
            return person;
        }

        [HttpDelete("delete")]
        public void Delete(int id)
        {
            var existPerson = PersonList.Where(x => x.Id == id).First();
            PersonList.Remove(existPerson);
        }
    }
}
