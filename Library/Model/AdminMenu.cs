
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Library.Model
{
  public  class AdminMenu
    {
        AdminMenu()
        {
            AdminService adminService = new AdminService();
            Console.WriteLine("1)Добавить читателя \n2)Изменить пароль читателя\n3)Изменить пароль админа\n4)Исключить читателя");
            int swtc = Int32.Parse(Console.ReadLine());
            switch (swtc)
            {
                case 1:
                    adminService.CreateReader();
                    break;
                case 2:
                    adminService.ChangePasswordToReader();
                    break;
                case 3:
                    adminService.ChangeAdminPassword();
                    break;
               
            }
        }
    }
}