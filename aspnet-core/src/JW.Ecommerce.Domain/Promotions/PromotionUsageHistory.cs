using System;
using Volo.Abp.Domain.Entities;

namespace JW.Ecommerce.Promotions;

public class PromotionUsageHistory : Entity<Guid>
{
    public Guid PromotionId { get; set; }
    public Guid OrderId { get; set; }

}