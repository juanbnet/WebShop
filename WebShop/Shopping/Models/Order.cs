using System;
using System.Collections.Generic;

namespace Shopping.Models;

public class Order
{
    public int OrderId { get; set; }

    public int OrderNumber { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
