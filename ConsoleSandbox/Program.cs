using System;
using UBDPLib;

namespace ConsoleSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            UBDPControler controler = new();
            var result = controler.GetMyAccount();
            Console.WriteLine(result);
        }
    }
}
