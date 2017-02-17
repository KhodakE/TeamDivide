using GolyukLib.PaymentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamDivide;

namespace GolyukLib.Ticket
{
    class Ticket : Iticket
    {
        TansportAddPayListener pay_method;
        TransportTicketListener transport_method;

        double balance;

        public IPrice Price
        {
            get
            {
                return new EasyTicketPrice();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public TansportAddPayListener TansportAddPayListener
        {
            get
            {
                return TicketPayListener;
            }

            set
            {
                pay_method = value;
                this.TicketPaySystemEvent += value;
            }
        }

        public TransportTicketListener TransportTicketListener
        {
            get
            {
                return TicketTransportListener;
            }

            set
            {
                transport_method = value;
                this.TransportTicketEvent += value;
            }
        }

        public event TansportAddPayListener TicketPaySystemEvent;
        public event TransportTicketListener TransportTicketEvent;

        void TicketTransportListener(ITransportTicketInformation info)
        {
            ITransportTicketInformation reply = new EasyTransportTicketInfo();

            switch (info.ITicketStatus.Status)
            {                
                case "give me money":
                    reply.Price = Price;
                    reply.ITicketStatus.Status = "Money";
                    break;
                case "ok":
                    TransportTicketEvent -= transport_method;
                    break;
                default:
                    //if error
                    break;
            }

            TransportTicketEvent(reply);
        }

        void TicketPayListener(IPayStatus status)
        {
            balance += status.Amount;

            TicketPaySystemEvent -= pay_method;
        }
    }
}
