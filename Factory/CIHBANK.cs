using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class CIHBANK : IBank
    {
        public string GetName()
        {
            return "This is CIHBANK ";
        }

        public IPaymentCard PaymentCardName(string name)
        {
            switch (name)
            {
                case "visacard": return new VisaCard();

                case "mastercard": return new MasterCard();

                case "Paypal": return new Paypal();

                default: return null;
            }
        }
    }
}
