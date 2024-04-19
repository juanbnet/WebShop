using GraphQL;
using GraphQL.Types;

using Shopping.Interfaces;
using Shopping.Type;

namespace Shopping.Query
{
    public class CustomerQuery : ObjectGraphType
    {
        private readonly ICustomerRepository _repository;
        public CustomerQuery(ICustomerRepository CustomerRepository)
        {
            _repository = CustomerRepository;

            Field<ListGraphType<CustomerType>>("Customers").Resolve(context =>
            {
                return CustomerRepository.GetCustomers();
            });

            Field<CustomerType>("Customer").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "CustomerId" })).Resolve(context =>
            {
                return CustomerRepository.GetCustomerById(context.GetArgument<int>("CustomerId"));
            });

        }
    }
}
