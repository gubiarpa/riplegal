using ripley.legal.entities.Models.Behavior;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ripley.legal.entities.Models
{
    public class Claimer : GuidDescBase
    {
        [Column("IDDocumentType")]
        public Guid DocumentType { get; set; }
    }
}
