using CoreApiTutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiTutorial.Services
{
    public interface IUserService
    {
        User Authenticate(string userName, string Password);
        IEnumerable<User> GetAll();
    }
}
