using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles._4_Interface_Segregation_Principle
{
    public class interfaceSegregationPrinciple
    {
        public static void Start()
        {
            //use main logic here
        }
    }

    public interface IBaseUser
    {
        string UserID { get; set; }
        string Password { get; set; }
    }

    public interface IAdmin : IBaseUser
    {
        void AddUser();
        void UpdateUser();
        void DeleteUser();
        void GetAllUser();
    }

    public interface IWriter : IBaseUser
    {
        void WriteDocument();
    }

    public class Admin : IAdmin
    {
        public string UserID { get; set; } = "Admin";
        public string Password { get; set; } = "DefaultPassword";

        public void AddUser()
        {
            //add user logic
        }

        public void DeleteUser()
        {
            //delete user logic
        }

        public void GetAllUser()
        {
            //Get all user logic
        }

        public void UpdateUser()
        {
            //update user logic
        }
    }

    public class Writer : IWriter
    {
        public string UserID { get; set; } = "Writer";
        public string Password { get; set; } = "DefaultPassword";


        public void WriteDocument()
        {
            //write document logic
        }
    }



}
