using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entity.Entities;
using Observer;

namespace Domain
{
    public class Status
    {
        public DataTable GetAllStatus()
        {
            var data = new DbAccess();
            var result = data.GetData_AllStatus();

            return result;
        }
        public DataSet GetStatus(Entity.Entities.Status obj)
        {
            var data = new DbAccess();
            var result = data.GetData_Status(obj);

            return result;
        }

        public void Post()
        {
            ConcreteUserObserver obs = new ConcreteUserObserver();
            obs.Notify();
        }
        public void Like()
        {

        }
    }
}
