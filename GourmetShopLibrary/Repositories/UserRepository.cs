using GourmetShopLibrary.Interfaces;
using GourmetShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopLibrary.Repositories
{
    public class UserRepository : ICustomerRepository
    {
        public void AddCustomer(User customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Product GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(User customer)
        {
            throw new NotImplementedException();
        }
    }
}
