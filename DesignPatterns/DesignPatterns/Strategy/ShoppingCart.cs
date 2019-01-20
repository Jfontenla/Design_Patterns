using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class ShoppingCart
    {
        private IPayment _iPayment;
        
        public ShoppingCart(IPayment iPayment)
        {
            this._iPayment = iPayment;   
        }
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
            return _iPayment.Pay();
        }
    }
}
