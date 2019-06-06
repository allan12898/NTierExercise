using System;
using Entity.Observer;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class Post : EntityBaseClass
    {
        private bool _like;
        User usr = new User();

        public int postID
        { get; set; }
        public bool Like
        {
            get
            {
                return _like;
            } set {
                if (_like != value)
                {
                    Notify();
                    _like = value;
                    
                }

            }
        }
        public List<User> getUser()
        {
            User obj = new User();

            return obj.getUser();
        }
        public void Notify()
        {
            foreach (User user in getUser())
            {
                user.Update(this);
            }


            Console.WriteLine("");
        }
    }
}
