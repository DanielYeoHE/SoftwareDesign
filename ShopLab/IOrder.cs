using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLab
{
    interface IOrder
    {
        Order clone();
    }
}
