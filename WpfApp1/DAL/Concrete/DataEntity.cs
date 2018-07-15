using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class User
    {
        public User()
        {
            Jobs = new List<Job>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SName { get; set; }
        [Required]
        public string TName { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int CityId { get; set; }
        [Required]
        public int Age { get; set; }

        public string Resume { get; set; }
        [Required]
        public string Email { get; set; }
        public string ImgPath { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }

    //public class Employer
    //{
    //    public Employer()
    //    {
    //        Jobs = new List<Job>();
    //    }

    //    public int Id { get; set; }
    //    [Required]
    //    public string Name { get; set; }
    //    [Required]
    //    public string SName { get; set; }
    //    [Required]
    //    public string TName { get; set; }
    //    [Required]
    //    public string NickName { get; set; }
    //    [Required]
    //    public string Password { get; set; }
    //    [Required]
    //    public string PhoneNumber { get; set; }
    //    [Required]
    //    public string City { get; set; }
    //    [Required]
    //    public int Age { get; set; }
    //    [Required]
    //    public string Email { get; set; }
    //    public string ImgPath { get; set; }
    //    public virtual ICollection<Job> Jobs { get; set; }
    //}

    public class Job
    {
        public int Id { get; set; }
        [Required]
        public string Topik { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Type Type { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public City City { get; set; }

        public string ImgPath { get; set; }
        [Required]
        public string NumberOfEmployees { get; set; }
        [Required]
        public string Info { get; set; }

        [Required]
        public string YourPosition { get; set; }

        [Required]
        public User User { get; set; }
    }

    public class Type
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Resume
    {
        public int Id { get; set; }
        [Required]
        public string FIO { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string PlaceLiving { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Xperience { get; set; }
        [Required]
        public string Education { get; set; }
        [Required]
        public string Language { get; set; }
    }
}