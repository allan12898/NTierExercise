using DataAccess;
using Entity.Observer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Entity.Entities
{
    public class Status : EntityBaseClass
    {
        ConcreteUserObserver obs = new ConcreteUserObserver();

        DbAccess conn = new DbAccess();

        private DataTable _user;
        public DataTable User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }
        private bool _like;
        public User StatusBy { get; set; }
        public DateTime TimePosted { get; set; }
        public string Content { get; set; }
        public bool Like
        {
            get
            {
                return _like;
            }
            set
            {
                if (_like != value)
                {
                    _like = value;
                    Notify();
                }

            }
        }
        public void Notify()
        {
            foreach (ConcreteUserObserver user in _user.Rows)
            {
                user.Update(this);
            }

            



            Console.WriteLine("");
        }

    }
}
