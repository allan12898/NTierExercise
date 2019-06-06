using System;
using Entity.Entities;


namespace Entity.Observer
{
    public class ConcreteUserObserver : IUserObserver
    {
        private string _Id;
        private bool _like;
        public void Update(Status obj)
        {

            Console.WriteLine("Notified like of {0}'s " + "change to {1}", obj.Id, obj.Like);

        }
    }
}
