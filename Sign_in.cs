using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
namespace Account
{
   public class Sign_in
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Sign_in (string log, string pass)
        {
            Login = log;
            Password = pass;
        }
        public static bool Check(string login, string password)
        {
            const string  path = "C:\\Users\\Admin Admin\\source\\repos\\Account\\Data.json";
            try
            {
                var tests = JsonConvert.DeserializeObject<List<Sign_in>>(File.ReadAllText(path));
              
                var temp = tests.Where(x => x.Login == login && x.Password == password).ToList();
                return temp.Count >0;
            }
            catch (Exception)
            {
                var test = JsonConvert.DeserializeObject<Sign_in>(File.ReadAllText(path));
                return test.Login == login && test.Password == password;
            }
        }
    }
}
