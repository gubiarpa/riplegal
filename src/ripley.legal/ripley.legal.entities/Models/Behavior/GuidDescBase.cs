using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.entities.Models.Behavior
{
    public abstract class GuidDescBase : IGuid
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
    }
}
