﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public interface IBank
    {
        public string GetName();
        
        public IPaymentCard PaymentCardName(string name);
    }
}
