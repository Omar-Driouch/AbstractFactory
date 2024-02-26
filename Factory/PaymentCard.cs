using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public interface IPaymentCard
    {
        public string PaymentCardName();
        
    }

    public class VisaCard : IPaymentCard
    {
      

        public string PaymentCardName()
        {
            return ("this is a visa card  ");
        }
    }

    public class MasterCard : IPaymentCard
    {
     

        public string PaymentCardName()
        {
            return ("this is a  MasterCard ");
        }

    }


    public class Paypal : IPaymentCard
    {


        public string PaymentCardName()
        {
            return ("this is a  Paypal ");
        }
    }
}
