using System;


namespace Observer
{
    public class ConcreteUserObserver : IUserObserver
    {
        private string _Id;
        private bool _like;
        public void Update()
        {
            //Console.WriteLine("Notified like of {0}'s " + "change to {2:C}", , Status, Status.Price);

        }
    }
}
