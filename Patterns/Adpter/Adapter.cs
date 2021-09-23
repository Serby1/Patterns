using System;
using System.Collections.Generic;
using System.Text;

namespace Adpter
{
    class Adapter : IUsers
    {
        private readonly Socket _soket;

        public Adapter(Socket soket)
        {
            this._soket = soket;
        }
        public string Phone_Charging()
        {
            return $"C помощью адапетра '{this._soket.SetCharging()}'";
        }
    }
}
