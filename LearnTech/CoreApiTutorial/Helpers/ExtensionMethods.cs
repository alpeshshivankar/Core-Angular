using CoreApiTutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiTutorial.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<User> WithOutPasswords(this IEnumerable<User> users)
        {
            return users.Select(x => x.WithOutPassword());
        }

        public static User WithOutPassword(this User user)
        {
            user.Password = null;
            return user;
        }
    }
}
