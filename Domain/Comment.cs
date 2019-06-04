using DataAccess;
using System;
using System.Data;
using Entity.Entities;

namespace Domain
{
    public class Comment
    {
        public DataSet GetAllCommentByStatusId(Entity.Entities.Comment obj)
        {
            DbAccess conn = new DbAccess();
            DataSet result = conn.GetData_Comment(obj);    
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
