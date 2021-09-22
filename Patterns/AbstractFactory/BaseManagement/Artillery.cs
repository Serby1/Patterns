using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.BaseManagement
{
    /// Абстрактный базовый класс, описывающий функциональное поведение артиллерии
    /// произвольной игровой расы.
    public abstract class Artillery
    {
        //метод описывающий маскировку
        public abstract void Disguise();

        //метод описывающий стрельбу 
        public abstract void Shoot();
    }
}
