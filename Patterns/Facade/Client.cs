using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Client
    {
        // Клиентский код работает со сложными подсистемами через простой
        // интерфейс, предоставляемый Фасадом. Когда фасад управляет жизненным
        // циклом подсистемы, клиент может даже не знать о существовании
        // подсистемы. Такой подход позволяет держать сложность под контролем.
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}
