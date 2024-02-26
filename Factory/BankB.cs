using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class BankB: IBank
    {
 
        public string GetName()
        {
            return ("Get Bank Name  B ");
        }

        public IPaymentCard PaymentCardName(string name)
        {

           return new VisaCard();

            
            
        }
    }
}
