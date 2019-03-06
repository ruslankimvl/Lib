using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    class ServiceMenu
    {
        public void Registration(Person user)
        {
            using (var db = new LiteDatabase("Books.db"))
            {
                var users = db.GetCollection<Person>("Users");
                users.Insert(user);
            }
        }
        public Person LogOn(string login, string password, out string message)
        {
            Person user = null;

            try
            {
                using (var db = new LiteDatabase(@"kkb.db"))
                {

                    var users = db.GetCollection<Person>("Users");

                    IEnumerable<Person> results =
                    users.Find(x => x.name.Equals(login) &&
                    x.password.Equals(password));

                    if (results.Any())
                    {
                        message = "";
                        return results.FirstOrDefault();
                    }
                    else
                    {
                        message = "Неправильно ввели логин или пароль";
                        return user;
                    }

                }

            }
            catch (Exception ex)
            {
                message = ex.Message;
                return user;
            }

        }
    }
}