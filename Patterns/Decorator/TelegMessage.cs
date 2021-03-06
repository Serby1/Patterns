using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class TelegMessage : Decorator
    {
        public TelegMessage(Notefiler note) : base(note)
        {
        }

        // Декораторы могут вызывать родительскую реализацию операции, вместо
        // того, чтобы вызвать обёрнутый объект напрямую. Такой подход упрощает
        // расширение классов декораторов.
        public override string Message()
        {
            return $"Отправка уведомлений настроена в Telegram \n{base.Message()}";
        }
    }
}
