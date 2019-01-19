using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class CreditCardPayment : IPayment
    {
        public string Pay()
        {
            return "this form to pay it is through credit card";
        }
    }
}
