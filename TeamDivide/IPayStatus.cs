using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDivide
{
    public interface IPayStatus
    {
        double Amount { get; set; }
        int CartNumber { get; set; }
        int CVV { get; set; }
        DateTime CartData { get; set; }
    }
}