using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.USSR
{
    public class USSR_Artvillery : BaseManagement.Artillery

    {
        public override void Disguise()
        {
            Console.WriteLine( "орудие спрятано"); 
        }

        public override void Shoot()
        {
            Console.WriteLine("огонь");
        }
    }
}
