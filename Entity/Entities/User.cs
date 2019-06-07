using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public class User : EntityBaseClass 
    {
        public User(string _name)
        {
            this.Name = _name;
        }

        public string Name { get; set; }
        public string Company { get; set; }
        public string Picture { get; set; }
        public List<Post> UserPost =  new List<Post>();
        public void Update(Post obj)
        {
            Console.WriteLine("Notified {0} like of \"{1}\" " + "change to {2}", this.Name, obj.Content, obj.Like);

        }


    }
}
