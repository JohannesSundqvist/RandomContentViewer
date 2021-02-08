using RandomContentViewer2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomContentViewer2.Interfaces
{
    public interface IDataContext
    {
        List<User> GetUsers();

        string AddPerson(User user);
    }
}
