using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestService
{
    public class RestService : IRestService
    {
        public User GetObjectUser(string FirstName, string LastName)
        {
            Log($"GetObjectUser({FirstName} {LastName})");
            return new User() { id = DateTime.Now.Ticks, FisrtName = FirstName, LastName = LastName };
        }

        public string GetStringUserFullName(string FirstName, string LastName)
        {
            Log($"GetStringUserFullName({FirstName} {LastName})");
            return $"{LastName}, {FirstName}";
        }

        public string GetStringUserName()
        {
            Log("GetStringUserName()");
            return "John";
        }

        private void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
