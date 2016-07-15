using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloGitPOC
{
    class myClass
    {
        int a, b;
        public myClass(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }

        public int helloWorld(int i)
        {
            return i * i;
        }

        public int hellocube(int i)
        {
            return i * i * i;

        }
    }
}
