using BLL.Abstract;
using DAL;
using DAL.Abstract;
using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class Operations : IMyBll
    {
        private readonly IDal _dal;

        public Operations(IDal dal)
        {
            _dal = dal;
        }

        public bool Registration(string name, string sname, string tname, string nickname, string password, string phonenumber, int city, int age, string email)
        {
            User user = new User
            {
                Name = name,
                SName = sname,
                TName = tname,
                NickName = nickname,
                Password = password,
                PhoneNumber = phonenumber,
                CityId = city,
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

        public void AddJob(string name, DAL.Concrete.Type type, int salary, string info, string path, User user)
        {
            Job job = new Job
            {
                Name = name,
                Type = type,
                Salary = salary,
                Info = info,
                ImgPath = path,
                User = user
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
                _dal?.DelJob(a);
            }
        }

        public bool Registration(string name, string sname, string tname, string nickname, string password, int age, string email)
        {
            throw new NotImplementedException();
        }
    }
}

