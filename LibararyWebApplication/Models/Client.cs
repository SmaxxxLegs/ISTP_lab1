using System;
using System.Collections.Generic;

namespace LibararyWebApplication.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
