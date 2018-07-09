using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL.Concrete;

namespace WcfService1 //idu nahui
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddJob(string name, DAL.Concrete.Type type, int salary, string info, string path, User user)
        {
            throw new NotImplementedException();
        }

        public void DelJob(Job a)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool Registration(string name, string sname, string tname, string nickname, string password, int age, string email)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(string nickname, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
