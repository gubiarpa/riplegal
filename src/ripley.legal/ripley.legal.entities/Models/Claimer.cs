using ripley.legal.entities.Models.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.entities.Models
{
    public class Claimer : GuidDescBase
    {
        public IGuid DocumentType { get; set; }
    }
}
