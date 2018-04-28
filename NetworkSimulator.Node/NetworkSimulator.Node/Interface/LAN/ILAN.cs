using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSimulator.Node.Interface.LAN
{
   public interface ILAN:INode
    {
        long BandWidthBytes { get; set; }
        bool IsActive { get; set; }
        List<ILAN> Childs { get; set; }
        int ChildsCount { get; set; }
    }
}
