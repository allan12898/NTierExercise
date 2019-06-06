using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public class User : EntityBaseClass 
    {

        public string Name { get; set; }
        public string Company { get; set; }
        public string Picture { get; set; }
        public List<Post> UserPost =  new List<Post>();
        public void Update(Post obj)
        {
            Console.WriteLine("Notified like of \"{0}\" " + "change to {1}", obj.Content, obj.Like);

        }


    }
}
