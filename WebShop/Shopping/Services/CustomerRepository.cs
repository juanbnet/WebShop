using Shopping.Data;
using Shopping.Interfaces;
using Shopping.Models;

namespace Shopping.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly GraphQLDbContext _dbContext;

        public CustomerRepository(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }
        public bool AddCustomer(List<Customer> customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.FirstOrDefault(c => c.CustomerId == id);
        }


    }
}
