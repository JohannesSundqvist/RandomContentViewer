using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RandomContentViewer2.Models
{
    [Table("users")]
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public User()
        {

        }

        public User(string set_all)
        {
            this.Username = this.Country = this.Gender = set_all;
            this.Id = this.Age = 0;
        }
    }
}
