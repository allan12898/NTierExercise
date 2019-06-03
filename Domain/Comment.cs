using DataAccess;
using System;
using System.Data;
using Entity.Entities;

namespace Domain
{
    public class Comment
    {
        public DataSet GetAllCommentByStatusId(Entity.Entities.Status obj)
        {
            DbAccess conn = new DbAccess();
            DataSet result = conn.GetData_Status(obj);    
            return result;
        }

        public void PostComment()
        {

        }
        public void Reply()
        {

        }
        public void Like()
        {

        }


    }
}
