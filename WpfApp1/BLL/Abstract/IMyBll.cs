﻿using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IMyBll
    {
        bool Registration(string name, string sname, string tname, string nickname, string password, int age, string email);
        bool SignIn(string nickname, string pass);
        void AddJob(string name, DAL.Concrete.Type type, int salary, string info, string path, User user);
        void DelJob(Job a);
    }
}
