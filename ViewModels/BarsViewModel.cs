using Asp.net_Core_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Core_Project.ViewModels
{
    public class BarsViewModel
    {
      public IEnumerable<Bar> Bars { get; set; }
    }
}
