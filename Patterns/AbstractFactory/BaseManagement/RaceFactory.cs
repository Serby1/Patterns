using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.BaseManagement
{
    // Абстрактный базовый класс, описывающий методы создания типовых игровых сущностей
    // произвольной расы.
    public abstract class RaceFactory
    {
      
            
            /// Создание пехоты
            
            /// <returns>Абстрактная пехота/returns>
            public abstract Infantry CreateInfantry();

            
            /// Создание танка
            
            /// <returns>Абстрактная артилерия</returns>
            public abstract Artillery CreateArtillery();

            
           
            
            /// <returns>Абстрактный танкс</returns>
            public abstract Tank CreateTank();
        
    }
}
