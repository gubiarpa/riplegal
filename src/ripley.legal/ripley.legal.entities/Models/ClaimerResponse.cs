﻿using ripley.legal.entities.Models.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.entities.Models
{
    public class ClaimerResponse : GuidDescBase
    {
        public IGuid DocumentType { get; set; }
    }
}
