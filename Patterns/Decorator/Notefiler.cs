using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //Базовый класс компонента, который будет изменяться декораторами
    public abstract class Notefiler
    {
        public abstract string Message();
    }
}
