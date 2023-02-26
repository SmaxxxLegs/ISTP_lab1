using System;
using System.Collections.Generic;

namespace LibararyWebApplication.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int ClientId { get; set; }

    public int StatusId { get; set; }

    public string ShippingInfo { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<ProductOrder> ProductOrders { get; } = new List<ProductOrder>();

    public virtual Status Status { get; set; } = null!;
}
