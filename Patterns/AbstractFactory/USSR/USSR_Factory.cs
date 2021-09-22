using AbstractFactory.BaseManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.USSR
{
    public class USSR_Factory: BaseManagement.RaceFactory
    {
        //создание пехоты
        public override Infantry CreateInfantry()
        {
            return new USSR_Infantry();
        }

        //создание танков
        public override Tank CreateTank()
        {
            return new Tank_T_34();
        }

        //создание артиллерии 
        public override Artillery CreateArtillery()
        {
            return new USSR_Artvillery();
        }
    }
}
