using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class BankFactory : IBankFactory
    {
        public IBank CreateBank(string name)
        {
            if (name == "1") 
            {
                return (new BankA());
            }
            if (name == "2")
            {
                return (new BankB());
            }
            else
            {
                return (null);
            }
        }
    }
}
