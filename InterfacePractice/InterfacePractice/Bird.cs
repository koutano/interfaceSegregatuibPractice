using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class Bird : IBird
    {
        public void eat()
        {
            // 食事をする処理
            Console.WriteLine("メシウマ");
        }

        public void sleep()
        {
            // 眠る処理
            Console.WriteLine("すやすや");
        }

        public void fly()
        {
            // 飛ぶ処理
            Console.WriteLine("I can fly!!!");
        }

        
    }
}
