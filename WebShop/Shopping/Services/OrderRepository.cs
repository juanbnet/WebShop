using Shopping.Interfaces;
using Shopping.Models;

namespace Shopping.Services
{
    public class OrderRepository : IOrderRepository
    {
        public bool AddOrder(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
