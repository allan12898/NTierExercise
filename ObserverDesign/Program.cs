using System;
using System.Collections.Generic;
using System.Data;
using Domain;
using Entity.Entities;
using Entity.TypeOfGroup;
using Entity.SocialMedia;

namespace ObserverDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();
            post.Content = "this is sample post";
            User user1 = new User("user1");
            User user2 = new User("user2");

            post.AddObserver(user1);
            post.AddObserver(user2);
            user1.UserPost.Add(post);
            user1.UserPost[0].Like = true;
            user1.UserPost[0].Like = false;

            GroupCollection[] Groups = new GroupCollection[2];

            Groups[0] = new Talent();
            Groups[1] = new Recreational();

            foreach (GroupCollection category in Groups)
            {
                Console.WriteLine("Category {0}", category.GetType().Name);
                foreach (Group group in category.Groups)
                {
                    Console.WriteLine("Group {0} was created", group.GetType().Name);
                }
            }

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
