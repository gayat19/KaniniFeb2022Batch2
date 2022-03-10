using ModelsLibrary;
using MyDALibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBLibrary
{
    public class UserRepo : IRepo<string, User>
    {
        public User Add(User item)
        {
            throw new NotImplementedException();
        }

        public User Get(User item)
        {
            return new UserDAL().Login(item);
        }

        public ICollection<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
