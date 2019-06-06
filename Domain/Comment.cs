using DataAccess;
using System;
using System.Data;
using Entity.Entities;

namespace Domain
{
    public class Comment
    {
        DbAccess conn = new DbAccess();

        public DataSet GetAllCommentByStatusId(Entity.Entities.Comment obj)
        {
            DataSet result = conn.GetData_Comment(obj.Id);    
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
