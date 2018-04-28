using System;

namespace NetworkSimulator.Node.Interface
{
    public interface INode
    {
        string SSID { get; set; }
        string Name { get; set; }
        string AdapterName { get; set; }
        string Mac { get; set; }
        string Ipv4 { get; set; }
        string Ipv6 { get; set; }
        string Description { get; set; }
        DateTime CreatedDate { get; set; }
        TimeSpan Uptime { get; set; }




    }
}
