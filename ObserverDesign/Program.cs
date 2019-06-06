using System;
using System.Collections.Generic;
using System.Data;
using Domain;
using Entity.Entities;

namespace ObserverDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Status stat = new Status();
            //var result = stat.GetAllStatus();
            //DataTable dt = result.Tables[0]; 
            //Console.WriteLine(result.);
            User user1 = new User();
            user1.UserPost.Add(new Post());
            user1.UserPost.Add(new Post());
            user1.UserPost[0].Like = true;
            user1.UserPost[0].Like = false;

            //foreach (DataRow row in result.Rows)
            //{
            //    Console.WriteLine(row[0].ToString());
            //    Console.WriteLine(row[1].ToString());
            //    Console.WriteLine(row[2].ToString());
            //    Console.WriteLine(row[3].ToString());
            //    Console.WriteLine(row[4].ToString());
            //}
            //Console.WriteLine(result);
        }
    }
}
