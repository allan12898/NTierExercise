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
            Post post = new Post();
            post.Content = "this is sample post";
            User user1 = new User();
            
            post.AddObserver(user1);
            user1.UserPost.Add(post);
            user1.UserPost.Add(new Post());
            user1.UserPost[0].Like = true;
            user1.UserPost[0].Like = false;



            //Console.WriteLine("Hello World!");
            //Status stat = new Status();
            //var result = stat.GetAllStatus();
            //DataTable dt = result.Tables[0]; 
            //Console.WriteLine(result.);

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
