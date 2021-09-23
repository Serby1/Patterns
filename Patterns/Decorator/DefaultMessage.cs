using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //приложение для  нашего оповещения по умолчанию 
    class DefaultMessage : Notefiler
    {
        public override string Message()
        {
            return "\n";
        }
    }
}
