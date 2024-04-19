using Shopping.Models;

namespace Shopping.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        bool AddCustomer(List<Customer> customer);
    }
}
