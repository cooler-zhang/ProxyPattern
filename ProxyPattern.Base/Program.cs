using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Base
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = new MathServiceProxy();
            int a = 1;
            int b = 2;
            Console.WriteLine($"{a}+{b}={proxy.Add(1, 2)}");
            Console.ReadLine();
        }
    }
}