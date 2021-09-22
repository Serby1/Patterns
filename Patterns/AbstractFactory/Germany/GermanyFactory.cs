using AbstractFactory.BaseManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Germany
{
    /// Класс, описывающий методы создания типовых сущностей
    /// для Немцев
    public class GermanyFactory : BaseManagement.RaceFactory
    {
        //создание пехоты
        public override Infantry CreateInfantry()
        {
            return new GermanyInfantry();
        }

        //создание танков
        public override Tank CreateTank()
        {
            return new TankTiger();
        }

        //создание артиллерии 
        public override Artillery CreateArtillery()
        {
            return new GerArtillery();
        }
    }
}
