﻿using System;
using System.Collections.Generic;

namespace LibararyWebApplication.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<ProductOrder> ProductOrders { get; } = new List<ProductOrder>();
}
