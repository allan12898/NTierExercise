using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Domain
{
    public class Status
    {
        //Entity.Entities.Status stat = new Entity.Entities.Status();
        DbAccess conn = new DbAccess();
        Entity.Entities.Status stat = new Entity.Entities.Status();
        public Status()
        {
            stat.User = new DbAccess().GetData_AllStatus();
        }
        public DataTable GetAllStatus()
        {
            var data = new DbAccess();
            var result = data.GetData_AllStatus();
            return result;
        }
        public DataSet GetStatus(Entity.Entities.Status obj)
        {
            var data = new DbAccess();
            var result = data.GetData_Status(obj.Id);
            return result;
        }


        public void Like(Entity.Entities.Status obj, bool state)
        {
            obj.Like = true;
            conn.LikeStatus(obj.Id);
        }
        public void Unlike(Entity.Entities.Status obj)
        {
            conn.UnlikeStatus(obj.Id);
            obj.Like = false;
        }


    }
}
