using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.SRP
{
    //At a time single responsiblity priciple are given and single responsible to each
    class user
    {
        bool Login(string username, string password)
        {
            //Main logic
            return true;
        }
        bool Registration(string username, string password, string Email)
        {
            //Main logic
            return true;
        }

    }
    class Logger
    {
        void Log(string error)
        {
            //Main logic
        }
    }
    class Email
    {
        bool sendmail(string emailContent)
        {
            //Main logic
            return true;
        }
    }
}
