using System;
using System.Collections.Generic;

namespace Roost.Models
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public string MessageName { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageCreatedDate { get; set; }
    }
}
