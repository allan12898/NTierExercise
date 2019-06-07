using Entity.TypeOfGroup;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.SocialMedia
{
    public class Recreational : GroupCollection
    {
        public override void CreateGroup()
        {
            Groups.Add(new Gaming());
            Groups.Add(new Programming());
            Groups.Add(new Singing());
        }
    }
}
