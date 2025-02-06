using GourmetShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopLibrary.Interfaces
{
    internal interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        Product GetUserById(int id);
        void AddUser(User customer);
        void UpdateUser(User customer);
        void DeleteUserById(int id);
    }
}
