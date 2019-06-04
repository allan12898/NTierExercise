using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class Status :EntityBaseClass
    {
        public User StatusBy { get; set; }
        public DateTime TimePosted { get; set; }
        public string Content { get; set; }
        public bool Like { get; set; }

    }
}
