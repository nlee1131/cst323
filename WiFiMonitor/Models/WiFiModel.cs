using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WiFiMonitor.Models
{
    [DataContract]
    public class WiFiModel
    {
        [DataMember]
        public ClientModel client { get; set; }
        [DataMember]
        public int bytes_sent { get; set; }
        [DataMember]
        public double download { get; set; }
        [DataMember]
        public string timestamp { get; set; }
        [DataMember]
        public string share { get; set; }
        [DataMember]
        public int bytes_received { get; set; }
        [DataMember]
        public double ping { get; set; }
        [DataMember]
        public double upload { get; set; }
        [DataMember]
        public ServerModel server { get; set; }

    }
}
 