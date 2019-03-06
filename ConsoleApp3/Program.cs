using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class HelloWorld
    {
        private static string strHelloWorld;

        static HelloWorld()
        {
            strHelloWorld = "Hello World";
        }
        void writeHelloWorld()
        {
            Console.WriteLine(strHelloWorld);
        }

        public static void Main()
        {
            HelloWorld hw = new HelloWorld();
            hw.writeHelloWorld();
        }
    }
}