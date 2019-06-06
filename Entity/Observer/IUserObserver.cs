using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Observer
{
    public interface IUserObserver
    {
        void Update(Status obj);
    }
}
