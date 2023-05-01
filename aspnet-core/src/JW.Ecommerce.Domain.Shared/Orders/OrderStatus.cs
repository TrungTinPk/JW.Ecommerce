using System;
using System.Collections.Generic;
using System.Text;

namespace JW.Ecommerce.Orders
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}
