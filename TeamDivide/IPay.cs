using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDivide
{
    public interface IPaymentSystem
    {
        event TansportAddPayListener TicketPaySystemEvent;

        IPrice Price { get; set; }
        TansportAddPayListener TansportAddPayListener { get; set; }
    }
}