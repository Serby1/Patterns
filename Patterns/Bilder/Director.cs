using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // Директор может строить несколько вариаций продукта, используя
        // одинаковые шаги построения.
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartB();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
