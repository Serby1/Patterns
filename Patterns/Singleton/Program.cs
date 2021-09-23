using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            InstallationDisk d1 = InstallationDisk.Instance();
            InstallationDisk d2 = InstallationDisk.Instance();

            
            if (d1 == d2)
            {
                Console.WriteLine("Синагалтон работает, обе переменные содержат один и тот же экземпляр");

            }
            else
            {
                Console.WriteLine("Сингалтон не работает, переменные содержат ссылки на разные экземпляры");
            }
        }
    }
}
