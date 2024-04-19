using GraphQL.Types;

using Shopping.Models;

namespace Shopping.Type
{
    public class CustomerType: ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(c => c.CustomerId);
            Field(c => c.CustomerName);
            Field(c => c.Email);
            Field(c => c.PhoneNumber);
        }

    }
}
