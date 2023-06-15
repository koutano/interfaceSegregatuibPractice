using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class Human : IHuman
    {
        public void eat()
        {
            Console.WriteLine("メシウマ");
            throw new NotImplementedException();
        }

        //public void fly()
        //{
        //    throw new NotImplementedException();
        //}

        public void sleep()
        {
            Console.WriteLine("すやすや");
            throw new NotImplementedException();
        }

        public void swim()
        {
            Console.WriteLine("すいすい");
            throw new NotImplementedException();
        }
    }
}
