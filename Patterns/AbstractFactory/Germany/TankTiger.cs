using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Germany
{
    /// Класс, описывающий функциональное поведение танка Немцев
    public class TankTiger : BaseManagement.Tank
    {
        public TankTiger()
        {
            Console.WriteLine("РРРРРР");
        }

        //метод реализующий стрельбу этого танка
        public override void Shoot()
        {
            Console.WriteLine("Навожусь...");
        }

        //метода реализующий движение танка
        public override void Move()
        {
            Console.WriteLine("Уже в пути! ");
        }

        //метод реализающий починку гусеницы
        public override void Repair()
        {
            Console.WriteLine("Снова в строю!");
        }

    }
}
