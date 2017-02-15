using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamDivide;

namespace Tram
{
    public class Tram:ITransport
    {
        string Type { get; set; }
        double Amount { get; set; }

        public IPrice Price
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public TransportTicketListener TransportTicketListener
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event TransportTicketListener TransportTicketEvent;
    }
}
