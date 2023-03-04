using Volo.Abp.Domain.Entities;

namespace JW.Ecommerce.Products;

public class Tag : Entity<string>
{
    public string Name { get; set; }
}