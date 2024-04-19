using System;
using System.Collections.Generic;

namespace Shopping.Models;

public class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<ProductsCategory> ProductsCategories { get; set; } = new List<ProductsCategory>();
}
