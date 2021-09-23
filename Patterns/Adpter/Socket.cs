using System;
using System.Collections.Generic;
using System.Text;

namespace Adpter
{
    // Адаптируемый класс содержит полезную нам энергию для зарядки тлф, но его
    // интерфейс несовместим  с существующим клиентским разъемом. Адаптируемый
    // класс нуждается в некоторой доработке,  прежде чем клиент сможет
    // его использовать.
    class Socket
    {
        public string SetCharging()
        {
            return "Зарядка пошла...";
        }
    }
}
