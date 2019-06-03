using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class Comment : EntityBaseClass
    {
        public int StatusId { get; set; }
        public string Content { get; set; }
        public bool Like { get; set; }
    }
}
