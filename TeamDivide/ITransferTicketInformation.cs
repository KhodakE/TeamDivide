using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDivide
{
    public interface ITransportTicketInformation
    {
        IPrice Price { get; set; }
        ITicketStatus ITicketStatus { get; set; }
    }
}