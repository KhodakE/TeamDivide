using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamDivide;

namespace GolyukLib
{
    public class PayStatusPayPal : IPayStatus
    {
        double _amount;
        DateTime _cartdata;
        int _cartnumber;
        int _cvv;

        public PayStatusPayPal() { }
        public PayStatusPayPal(double amount, DateTime cartdata, int cartnumber, int cvv)
        {
            _amount = amount;
            _cartdata = cartdata;
            _cartnumber = cartnumber;
            _cvv = cvv;
        }

        public double Amount
        {
            get
            {
                return _amount + (_amount * 0.025); //2.5% коммиссия
            }

            set
            {
                _amount = value;
            }
        }

        public DateTime CartData
        {
            get
            {
                return _cartdata;
            }

            set
            {
                _cartdata = value;
            }
        }

        public int CartNumber
        {
            get
            {
                return _cartnumber;
            }

            set
            {
                _cartnumber = value;
            }
        }

        public int CVV
        {
            get
            {
                return _cvv;
            }

            set
            {
                _cvv = value;
            }
        }
    }
}
