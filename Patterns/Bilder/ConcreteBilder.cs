using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        // Новый экземпляр строителя должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // Все этапы производства работают с одним и тем же экземпляром
        // продукта.
        public void BuildPartA()
        {
            this._product.Add("Стены из дерева создана");
        }

        public void BuildPartB()
        {
            this._product.Add("Крыша из дерева создана");
        }

        public void BuildPartC()
        {
            this._product.Add("Пол из дерева создан");
        }

        //сброс значений
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
