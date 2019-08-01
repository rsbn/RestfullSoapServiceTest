using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace RestService
{
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetStringUserFullName/{FirstName}/{LastName}")]
        string GetStringUserFullName(string FirstName, string LastName);

        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetStringUserName/")]
        string GetStringUserName();

        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetObjectUser/{FirstName}/{LastName}")]
        User GetObjectUser(string FirstName, string LastName);
    }

    [DataContract(Namespace ="RestServiceDomain")]
    public class User
    {
        [DataMember]
        public long id { get; set; }
        [DataMember]
        public string FisrtName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
