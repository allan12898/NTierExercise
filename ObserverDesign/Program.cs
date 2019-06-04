using System;
using DataAccess;
using Domain;

namespace ObserverDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Status stat = new Status();
            var result = stat.GetAllStatus();
        }
    }
}
