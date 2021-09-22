using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Germany
{
    public class GerArtillery : BaseManagement.Artillery
    {
        public override void Disguise()
        {
            throw new NotImplementedException();
        }

        public override void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
