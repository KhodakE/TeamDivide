using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDivide
{
    public interface ITransportTicketCommunication
    {
        event TransportTicketListener TransportTicketCommunication;
    }
}