using GourmetShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopLibrary.Interfaces
{
    internal interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Product GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomerById(int id);
    }
}
