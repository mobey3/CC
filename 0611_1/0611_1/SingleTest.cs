using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0611_1
{
    class SingleTest
    {
        private static SingleTest inst;
        private int data;
        //static Random r = new Random();

        public SingleTest(Random r) // Random r << 메인에서 생성했기 때문에 매개변수
        {
            data = r.Next(1, 100);
        }

        public int getData()
        {
            return data;
        }

        public static SingleTest getInst(Random r)
        {
            if(inst == null)
            {
                inst = new SingleTest(r);
            }
            return inst;
        }


    }
}
