using System;
using DalApi;

namespace ConsoleDal
{
    class Program
    {
        static IDal dal = DalFactory.GetDal();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
