using Entity.TypeOfGroup;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.SocialMedia
{
    public class Talent : GroupCollection
    {
        public override void CreateGroup()
        {
            Groups.Add(new Dancing());
            Groups.Add(new Singing());
            Groups.Add(new Entertainment());
        }
    }
}
