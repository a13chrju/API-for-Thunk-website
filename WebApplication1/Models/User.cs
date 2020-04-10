using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public string Name { get; set; }

        public User(string dd)
        {
            this.Name = dd;
        }

        public User()
        {
        }
    }

  
}