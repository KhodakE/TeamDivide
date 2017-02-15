using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDivide
{
    public interface Iticket
    {
        event TransportTicketListener TransportTicketEvent;
        event TansportAddPayListener TicketPaySystemEvent;

        IPrice Price { get; set; }
        TransportTicketListener TransportTicketListener { get; set; }
        TansportAddPayListener TansportAddPayListener { get; set; }
    }
}