using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.TypeOfGroup
{
    public abstract class GroupCollection
    {
        private List<Group> _group = new List<Group>();
        public GroupCollection()
        {
            this.CreateGroup();
        }

        public List<Group> Groups
        {
            get { return _group; }
        }

    
        public abstract void CreateGroup();
    }
}
