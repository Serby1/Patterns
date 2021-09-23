using System;

namespace Adpter
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket soket = new Socket();
            IUsers user = new Adapter(soket);

            Console.WriteLine("Вилка и зарядка не сомвестимы");
            Console.WriteLine("Но с адптером пользователь может зарядить тлф");
            Console.WriteLine(user.Phone_Charging());
        }
    }
}
