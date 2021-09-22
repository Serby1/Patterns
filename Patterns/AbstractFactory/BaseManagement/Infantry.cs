using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.BaseManagement
{
    /// Абстрактный базовый класс, описывающий функциональное поведение пехоты
    /// произвольной игровой расы.
    public abstract class Infantry
    {
        //метод описывающий передвижение пехоты
        public abstract void Move();

        //метод описывающий стрельбу 
        public abstract void Shoot();

        /// Метод, описывающий разведку местности
        public abstract void Reconnoitre();
    }
}
