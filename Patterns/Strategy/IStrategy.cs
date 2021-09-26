using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
