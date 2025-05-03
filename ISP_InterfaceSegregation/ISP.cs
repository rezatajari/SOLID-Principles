using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP_InterfaceSegregation
{
    // ISP failed
    internal class ISP
    {
    }

    internal interface IWorker
    {
        void Cook();
        void Serve();
        void Clean();
        void ManageInventory();
    }


    internal class Chef : IWorker
    {
        public void Cook()
        {
            Console.WriteLine("Cooking...");
        }
        public void Serve()
        {
            throw new NotImplementedException();
        }
        public void Clean()
        {
            throw new NotImplementedException();
        }
        public void ManageInventory()
        {
            throw new NotImplementedException();
        }
    }

    internal class Waiter:IWorker
    {
        public void Cook()
        {
            throw new NotImplementedException();
        }

        public void Serve()
        {
            Console.WriteLine("Serve...");
        }

        public void Clean()
        {
            Console.WriteLine("Clean...");
        }

        public void ManageInventory()
        {
            throw new NotImplementedException();
        }
    }
}
