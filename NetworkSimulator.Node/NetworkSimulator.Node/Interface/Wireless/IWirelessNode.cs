using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSimulator.Node.Interface.Wireless
{
   public interface IWirelessNode: INode
    {
        
        long BandWidthBytes { get; set; }
        bool IsActive { get; set; }
        int RangeMeters { get; set; }
        List<IWirelessNode> Childs { get; set; }
        int ChildsCount { get; set; }

    }
}
