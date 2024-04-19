using Shopping.Models;

namespace Shopping.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrderById(int id);
        bool AddOrder(List<Order> orders);
    }
}
