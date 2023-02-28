using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibararyWebApplication.Models;

public partial class Category
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Field shouldn't be empty")]
    [Display(Name="Category")]
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();

}
