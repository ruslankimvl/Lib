using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
namespace Library.Model
{
    public class Libraryy
    {
        public Libraryy()
        {
            Console.WriteLine("Добро пожаловать!\n1)Зарегестрироваться\n2)Войти");
            ServiceMenu serviceMenu = new ServiceMenu();
            Person user = new Person("admin", "admin", "admin");
            int swtc = Int32.Parse(Console.ReadLine());
            switch (swtc)
            {
                case 1:
                    serviceMenu.Registration(user);
                    break;
                case 2:
                    serviceMenu.LogOn(user.login, user.password, out string message);
                    if (user.login=="admin"&& user.password == "admin" && user.name == "admin")
                    {
                        user = new Admin(user.login, user.password, user.name);
                        AdminMenu adminMenu = new AdminMenu();

                    }
                    break;
            }
        }


       
    }
}
