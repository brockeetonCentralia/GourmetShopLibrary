using GourmetShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopLibrary.Interfaces
{
    public interface IOrderItemRepository
    {
        void AddOrderItem(OrderItem orderItem);
        List<OrderItem> GetAllOrderItems();
        OrderItem GetOrderItemById(int id);
      
    }
}
