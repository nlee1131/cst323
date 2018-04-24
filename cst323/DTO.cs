using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace cst323
{
    [DataContract]
    public class DTO
    {
        public DTO(int ErrorCode, string ErrorMsg, List<string> Data)
        {
            this.ErrorCode = ErrorCode;
            this.ErrorMsg = ErrorMsg;
            this.Data = Data;
        }
        [DataMember]//status code of http request
        public int ErrorCode { get; set; }
        [DataMember]//message of http request
        public string ErrorMsg { get; set; }
        [DataMember]//list of scores
        public List<string> Data { get; set; }
    }
}