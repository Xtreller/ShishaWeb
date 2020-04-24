using Asp.net_Core_Project.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Core_Project.Models
{
    public class Comment : BaseModel<int>
    {
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }
        public int BarId { get; set; }
        public virtual Bar Bars { get; set; }

    }
}
