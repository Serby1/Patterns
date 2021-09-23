using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Client
    {
        public void ClientCode(Notefiler note)
        {
            Console.WriteLine("RESULT:" + note.Message());
        }
    }
}
