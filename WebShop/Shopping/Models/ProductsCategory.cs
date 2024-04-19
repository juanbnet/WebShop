using System;
using System.Collections.Generic;

namespace Shopping.Models;

public class ProductsCategory
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int ProductId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
