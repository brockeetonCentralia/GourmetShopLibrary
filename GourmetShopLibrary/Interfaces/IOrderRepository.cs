using GourmetShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopLibrary.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        Order GetOrderById(int id);
        List<Order> GetAllOrders();
    }
}
