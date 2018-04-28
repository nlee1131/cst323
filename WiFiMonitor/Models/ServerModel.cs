using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WiFiMonitor.Models
{
    [DataContract]
    public class ServerModel
    {
        [DataMember]
        public string latency { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public string lon { get; set; }
        [DataMember]
        public string cc { get; set; }
        [DataMember]
        public string host { get; set; }
        [DataMember]
        public string sponsor { get; set; }
        [DataMember]
        public string url2 { get; set; }
        [DataMember]
        public string lat { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public double d { get; set; }
    }
}