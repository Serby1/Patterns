using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.USSR
{
    public class Tank_T_34 : BaseManagement.Tank
    {
        public override void Move()
        {
            Console.WriteLine("начали движение");
        }

        public override void Repair()
        {
            Console.WriteLine("ну вот((");
        }

        public override void Shoot()
        {
            Console.WriteLine("огонь");
        }
    }
}
