using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace cst323
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "cst323/")]
        string PostSpeed(RequestInput json);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "SpeedData/")]
        DTO GetSpeeds();
        // TODO: Add your service operations here
    }

    [DataContract]
    public class RequestInput
    {
        [DataMember]
        public string data { get; set; }

        public RequestInput(string data)
        {
            this.data = data;
        }
    }
}
