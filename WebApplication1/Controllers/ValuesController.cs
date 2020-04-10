using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication1.Content;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        public List<User> Users = new List<User>();
        
        // GET api/values
        public List<Movie> Get()
        {
            using (DB_A410F2_VideostoreEntities myDB = new DB_A410F2_VideostoreEntities())
            {



                List<Movie> all = myDB.Movie.ToList();

              

                return all;
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        // POST api/values
     
        public Movie Send(string value)
        {
            using (DB_A410F2_VideostoreEntities myDB = new DB_A410F2_VideostoreEntities())
            {
                Movie newM = new Movie();
                newM.Id = 99;
                newM.Price = 991;
                newM.Title = value;
                myDB.Movie.Add(newM);
                myDB.SaveChanges();

                Movie addedMovie = myDB.Movie.OrderByDescending(x => x.Id).FirstOrDefault();
                return addedMovie;
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            using (DB_A410F2_VideostoreEntities myDB = new DB_A410F2_VideostoreEntities())
            {
                Movie delete = myDB.Movie.Where(x => x.Id == id).FirstOrDefault();
                myDB.Movie.Remove(delete);
                myDB.SaveChanges();
            }
        }
    }
}
