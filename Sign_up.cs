using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace Account
{
    public class Sign_up
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Sign_up(string log, string pass)
        {
            Login = log;
            Password = pass;
        }
        public static void AddDataToJson(Sign_up sign_Up)
        {
        const string path = "C:\\Users\\Admin Admin\\source\\repos\\Account\\Data.json";
            try
            {
                var accounts = JsonConvert.DeserializeObject<List<Sign_up>>(File.ReadAllText(path));
                accounts.Add(sign_Up);
                string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception)
            {
                var account = JsonConvert.DeserializeObject<Sign_up>(File.ReadAllText(path));
                List<Sign_up> temp = new List<Sign_up>();
                if (account == null) temp.Add(sign_Up);
                else
                {
                    temp.Add(account);
                    temp.Add(sign_Up);
                }
                string json = JsonConvert.SerializeObject(temp, Formatting.Indented);
                File.WriteAllText(path, json);
            }
        }
    }
}
