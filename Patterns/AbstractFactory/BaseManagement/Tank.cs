using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.BaseManagement
{
    /// Абстрактный базовый класс, описывающий функциональное поведение танка
    /// произвольной игровой расы.
    public abstract class Tank
    {
        /// Метод, описывающий стрельбу
        public abstract void Shoot();

        //метод описывающий перемещение
        public abstract void Move();

        //метод описываюший починку гусеницы
        public abstract void Repair();
    }
}
