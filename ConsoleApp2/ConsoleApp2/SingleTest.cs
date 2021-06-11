using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SingleTest
    {
        private static SingleTest inst;
        private int data;
        Random r = new Random();
        SingleTest()
        {
            data = (int)(r.Next(1,100));
        }
        public static SingleTest getInstance()
        {
            if(inst == null)
            {
                inst = new SingleTest();
            }
            return inst;
        }

        public int getData()
        {
            return data;
        }
    }
}
