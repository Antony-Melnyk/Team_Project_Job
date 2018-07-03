using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    internal class CustomInit<T> : DropCreateDatabaseIfModelChanges<Model1>
    {
        protected override void Seed(Model1 context)
        {
            context.Users.Add(new User { NickName = "lox", Name = "Roma", SName = "Andreev", TName = "Anatolyovuch", Age = 16, Email = "sss", Password = "1234" });
            context.SaveChanges();
            ///s
        }
    }
}
