using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Germany
{
    public class GermanyInfantry : BaseManagement.Infantry
    {
        public override void Move()
        {
            Console.WriteLine("Вперееед!!!");
        }

        public override void Reconnoitre()
        {
            Console.WriteLine("Ищем кусты");
        }

        public override void Shoot()
        {
            Console.WriteLine("Огонь");
        }
    }
}
