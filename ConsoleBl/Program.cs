using System;
using BlApi;

namespace ConsoleBl
{
    class Program
    {
        static IBL bl = BlFactory.GetBl();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
