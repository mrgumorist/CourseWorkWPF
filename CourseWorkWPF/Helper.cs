using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseWorkWPF
{
    static class Helper
    {
        public static List<User> users =new List<User>();
        public const string path = @"Listik.txt";
        static XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
        public static void Serialize()
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, users);
                }
            }
            catch
            {
                
            }
        }
        public static void Deserialize()
        {
           
            try
            {
              
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    users = (List<User>)formatter.Deserialize(fs);
                }
            }
            catch
            {
             
            }
            //User user = new User();
            //user.IsAccepted = true;
            //user.Login = "Admin";
            //user.Password = "Admin";
            //user.IsBanned = false;
            //users.Add(user);


        }

    }
}
