using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
  public class Blog:BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public string Location { get; set; }
        public string Photo { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
        public string PostedBy { get; set; }
        public int? LabelId { get; set; }
        public string ActionText { get; set; }
        public string EndPoint { get; set; }
        public Label Label { get; set; }



    }
}
