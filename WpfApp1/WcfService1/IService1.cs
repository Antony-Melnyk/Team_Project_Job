using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool Registration(string name, string sname, string tname, string nickname, string password, int age, string email);
        [OperationContract]
        bool SignIn(string nickname, string pass);
        [OperationContract]
        void AddJob(string name, DAL.Concrete.Type type, int salary, string info, string path, User user);
        [OperationContract]
        void DelJob(Job a);
    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
