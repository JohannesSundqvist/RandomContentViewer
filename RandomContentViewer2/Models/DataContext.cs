using Microsoft.EntityFrameworkCore;
using RandomContentViewer2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomContentViewer2.Models
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<User> user { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=true;");
        }

        public List<User> GetUsers()
        {
            var query = (from p in user
                         select p).ToList();

            return query;
        }
        public string AddPerson(User user)
        {
            using (var _context = new DataContext())
            {
                if (user == null)
                    throw new ArgumentNullException("AddPerson() is null");

                _context.user.Add(user);
                _context.SaveChanges();

                return user.Username;
            }
        }
    }
}
