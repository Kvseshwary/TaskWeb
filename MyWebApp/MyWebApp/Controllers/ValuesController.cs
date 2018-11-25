using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApp.Controllers
{
    public class person
    {
        public int MemberNumber { get; set; }
        public string ForeName { get; set; }
        public string Surname { get; set; }
        public List<products> product{ get; set; }
        
        
    }
    public class products
    {
        public string Name { get; set; }
        public string Cost { get; set; }
    }
    public class PersonController : ApiController
    {
        // GET api/values

        person[] persons = new person[]
   {
              new person{MemberNumber=1234567890,ForeName="Fred",Surname="Smith",product=new List<products>(){ new products { Name= "Healthcare", Cost="100" } } },
               new person{MemberNumber=1234567890,ForeName="Nilda",Surname="Jince",product=new List<products>(){ new products { Name= "Travel Insurance", Cost="200" } } },
              new person{MemberNumber=1234567891,ForeName="Joicy",Surname="Antony",product=new List<products>(){ new products { Name = "Vehicle Insurance", Cost = "200" } } },
              new person{MemberNumber=1234567892,ForeName="George",Surname="Smith",product=new List<products>(){ new products {Name= "Insurance", Cost="500" } } }
   };
        public IEnumerable<person> Get()
        {
            return persons;
            /*return new List<person> {
                new person{MemberNumber=1234567890,ForeName="Fred",Surname="Smith" },
                new person{MemberNumber=1234567891,ForeName="Peppa",Surname="George"},

                new person{MemberNumber=1234567892,ForeName="George",Surname="Smith"}
            };*/
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var product = persons.FirstOrDefault((p) => p.MemberNumber == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product); 
        }

        // POST api/values
        public void Post([FromBody]person value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]person value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
