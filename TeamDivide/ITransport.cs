using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDivide
{
    public interface ITransport
    {
        event TransportTicketListener TransportTicketEvent;

        IPrice Price { get; set; }
        TransportTicketListener TransportTicketListener { get; set; }
    }
}