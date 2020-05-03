using System;
using System.Collections.Generic;
using System.Text;

namespace Roost.Models
{
    public partial class Message
    {
        public int MessagetId { get; set; }
        public string MessageName { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageCreatedDate { get; set; }
    }
}
