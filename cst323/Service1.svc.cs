using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace cst323
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static DTO dto;
        public DTO GetSpeeds()
        {
            cstDAO service = new cstDAO();
            List<string> response = new List<string>();
            response = service.GetSpeeds();
            dto = new DTO(0, "", response);
            return dto;
        }

        public string PostSpeed(RequestInput json)
        {
            string response;
            cstDAO service = new cstDAO();
            if (service.CreateRow(json.data))
                response = "OK";
            else
                response = "FAIL";
            return response;
        }
    }
}
