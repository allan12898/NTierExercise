using System;
using Entity.Observer;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class Post : EntityBaseClass
    {
        private bool _like;
        public string Content { get; set; }
        public List<User> UserList = new List<User>();

        public void AddObserver(User user)
        {
            UserList.Add(user);
        }


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
        public void Notify()
        {

            //UserList.ForEach(User => User.Update(this));

            foreach (User user in UserList)
            {
                user.Update(this);
            }


            Console.WriteLine("");
        }
    }
}
