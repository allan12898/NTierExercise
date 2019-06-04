using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entity.Entities;

namespace Domain
{
    public class Status
    {
        public DataSet GetAllStatus()
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

        }
        public void Like()
        {

        }
    }
}
