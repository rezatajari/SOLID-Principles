using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    // OCP failed
    internal class OCP
    {
        void ChoiceYourFood(string foodName)
        {
            if (foodName == "Pizza")
            {
                Console.WriteLine("Pizza is ready");
            }
            else if (foodName == "Burger")
            {
                Console.WriteLine("Burger is ready");
            }
            else
            {
                Console.WriteLine("Salad is ready");
            }
        }
    }

    // OCP passed
    internal interface IFood
    {
        void Cook();
    }

    internal class Pizza : IFood
    {
        public void Cook()
        {
            Console.WriteLine("Pizza is ready");
        }
    }

    internal class Burger : IFood
    {
        public void Cook()
        {
            Console.WriteLine("Burger is ready");
        }
    }

    internal class Salad : IFood
    {
        public void Cook()
        {
            Console.WriteLine("Salad is ready");
        }
    }
}