using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class ShoppingCart
    {
        private IPayment iPayment;
        
        public string RemoveItems()
        {
            return "this method remove items";
        }

        public string GetItems()
        {
            return "i know the items where you wish buy";
        }

        public string Pay()
        {
            return iPayment.Pay();
        }
    }
}
