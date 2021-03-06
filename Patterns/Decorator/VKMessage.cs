using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class VKMessage : Decorator
    {
        public VKMessage(Notefiler note) : base(note)
        {
        }

        // Декораторы могут вызывать родительскую реализацию операции, вместо
        // того, чтобы вызвать обёрнутый объект напрямую. Такой подход упрощает
        // расширение классов декораторов.
        public override string Message()
        {
            return $"Отправка уведомлений настроена в VK \n {base.Message()}";
        }

    }
}
