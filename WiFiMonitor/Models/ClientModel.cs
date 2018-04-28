using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WiFiMonitor.Models
{
    [DataContract]
    public class ClientModel
    {
        [DataMember]
        public string rating { get; set; }
        [DataMember]
        public string loggedin { get; set; }
        [DataMember]
        public string isprating { get; set; }
        [DataMember]
        public string ispdlavg { get; set; }
        [DataMember]
        public string ip { get; set; }
        [DataMember]
        public string isp { get; set; }
        [DataMember]
        public string lon { get; set; }
        [DataMember]
        public string ispulavg { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public string lat { get; set; }
    }
}