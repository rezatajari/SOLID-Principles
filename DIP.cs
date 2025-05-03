using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    // DIP failed
    internal class DIP
    {
    }

    internal class KitchenOrderService
    {
        void Order()
        {
            Console.WriteLine("Order is to proper...");
        }

    }

    internal class CloudOrderService
    {
        void CloudOrder()
        {
            Console.WriteLine("Order is to proper...");
        }
    }



    // DIP passed
    internal interface IOrderSender
    {
        void SendOrder();
    }

    internal class KitchenOrderSender : IOrderSender
    {
        public void SendOrder()
        {
            Console.WriteLine("Order is to proper...");
        }
    }

    internal class CloudOrderSender : IOrderSender
    {
        public void SendOrder()
        {
            Console.WriteLine("Order is to proper...");
        }
    }
}
