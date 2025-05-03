using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{

    internal class SRP
    {
       
    }

    // SRP failed
    internal class GenerateCook
    {
        void Cook()
        {
            Console.WriteLine("Cook the food");
        }

        void Watier()
        {
            Console.WriteLine("take orders and serve.");
        }

        void Cashier()
        {
            Console.WriteLine("handle payments.");
        }
    }

    // SRP passed
    internal class Cook
    {
        void CookFood()
        {
            Console.WriteLine("Cook the food");
        }
    }

    internal class Waiter
    {
        void TakeOrders()
        {
            Console.WriteLine("take orders and serve.");
        }
    }

    internal class Cashier
    {
        void HandlePayments()
        {
            Console.WriteLine("handle payments.");
        }
    }
}
