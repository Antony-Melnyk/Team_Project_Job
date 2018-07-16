using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class DefaultDal : IDal
    {
        private readonly DbContext _ctx;
        public DefaultDal(DbContext ctx)
        {
            _ctx = ctx;
        }
        public bool Registration(string name, string sname, string tname, string nickname, string password, int age, string email)
        {
            User user = new User
            {
                Name = name,
                SName = sname,
                TName = tname,
                NickName = nickname,
                Password = password,
                Age = age,
                Email = email,
                ImgPath = null

            };

            using (Model1 m1 = new Model1())
            {
                if (m1.Users.FirstOrDefault(x => x.NickName == user.NickName) == null)
                {
                    m1.Users.Add(user);
                    m1.SaveChanges();
                    return true;
                }
                else return false;
            }
        }

        public bool SignIn(string nickname, string pass)
        {
            using (Model1 m1 = new Model1())
            {
                if (m1.Users.FirstOrDefault(x => x.NickName == nickname && x.Password == pass) != null)
                    return true;
                else
                    return false;
            }
        }

        public void AddJob(string name, string topik, DAL.Concrete.Type type, int salary, string info, string path, User user, City newCity, string position, string numberofemp)
        {
            Job job = new Job
            {
                Name = name,
                Type = type,
                Topik = topik,
                Salary = salary,
                Info = info,
                ImgPath = path,
                User = user,
                City = newCity,
                YourPosition = position,
                NumberOfEmployees = numberofemp
            };

            using (Model1 m1 = new Model1())
            {
                m1.Jobs.Add(job);
                m1.SaveChanges();
            }
        }

        public void DelJob(Job a)
        {
            using (Model1 m1 = new Model1())
            {
                m1.Jobs.Remove(a);
                m1.SaveChanges();
            }
        }

        public void AddJob(string name, Type type, int salary, string info, string path, User user)
        {
            throw new NotImplementedException();
        }

        public void AddJob(string name, Type type, int salary, string info, string path, User user, City newCity, string position, string numberofemp)
        {
            throw new NotImplementedException();
        }
        //public string GetDataById(int id)
        //{
        //    //return (_ctx as DBmodel).DataEntities.Single(d => d.Id == id).Data;
        //    //return _ctx?.Set<User>().Single(d => d.Id == id);

        //}
    }
}
