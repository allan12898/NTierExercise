using System;
using System.Data;
using DataAccess;
using Domain;

namespace ObserverDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Status stat = new Status();
            var result = stat.GetAllStatus();
            //DataTable dt = result.Tables[0]; 
            //Console.WriteLine(result.);
            foreach (DataRow row in result.Rows)
            {
                Console.WriteLine(row[0].ToString());
                Console.WriteLine(row[1].ToString());
                Console.WriteLine(row[2].ToString());
                Console.WriteLine(row[3].ToString());
                Console.WriteLine(row[4].ToString());
                Console.WriteLine(row[5].ToString());
            }
            //Console.WriteLine(result);
        }
    }
}
