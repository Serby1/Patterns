using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Decorator : Notefiler
    {
        protected Notefiler _notefiler;

        public Decorator(Notefiler notefiler)
        {
            this._notefiler = notefiler;
        }

        public void SetComponent(Notefiler notefiler)
        {
            this._notefiler = notefiler;
        }

        // Декоратор делегирует всю работу обёрнутому компоненту.
        public override string Message()
        {
            if (this._notefiler != null)
            {
                return this._notefiler.Message();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
