using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP_LiskovSubstitution
{
    // LSP failed
    internal class LSP
    {
        void Cookie(string cookieType)
        {
            if (cookieType == "chocolate chip")
            {
                Console.WriteLine("Baking chocolate chip cookies...");
            }
            else if (cookieType == "oatmeal raisin")
            {
                Console.WriteLine("Baking oatmeal raisin cookies...");
            }
            else if (cookieType == "DogCookie ")
            {

                throw new Exception("This cookie is not for humans.");

            }
            else
            {
                Console.WriteLine("Unknown cookie type.");
            }
        }
    }

    // LSP passed
    internal interface ICookie
    {
        void Bake();
    }

    internal interface IPetCookie : ICookie
    {
        void BakeForPets();
    }
    internal class ChocolateChipCookie : ICookie
    {
        public void Bake()
        {
            Console.WriteLine("Baking chocolate chip cookies...");
        }
    }

    internal class OatmealRaisinCookie : ICookie
    {
        public void Bake()
        {
            Console.WriteLine("Baking oatmeal raisin cookies...");
        }
    }

    internal class DogCookie : IPetCookie
    {
        public void Bake()
        {
            Console.WriteLine("Baking dog cookies...");
        }

        public void BakeForPets()
        {
            Console.WriteLine("Baking dog cookies for pets...");
        }
    }
}
