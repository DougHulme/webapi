using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
   
    public partial class radSpeedview
    {
        public DateTime? xaxis { get; set; }
        public long? download { get; set; }
        public long? upload { get; set; }
    }
}