using GourmetShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopLibrary.Interfaces
{
    internal interface IOrderRepistory
    {
        void AddOrder(Order order);
        void RemoveOrder(Order order);
        Order GetOrderById(int id);
        List<Order> GetAllOrders();
    }
}
