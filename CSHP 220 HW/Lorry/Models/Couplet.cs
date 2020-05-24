using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lorry
{
    public partial class Couplet
    {
        public int CoupletId { get; set; }
        public string CoupletRhyme { get; set; }
        public string CoupletContent { get; set; }
    }
}
