using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Core_Project.Models.Common
{
    public interface IAuditInfo
    {
           DateTime CreatedOn { get; set; }
           DateTime? ModifiedOn { get; set; }

    }
}
