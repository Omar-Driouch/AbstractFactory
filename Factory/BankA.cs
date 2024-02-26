using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class BankA : IBank
    {

        public string GetName()
        {
            return ("Get Bank Name  A ");
        }

        public IPaymentCard PaymentCardName(string name)
        {
            //here  we rteurn the object that we want
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
