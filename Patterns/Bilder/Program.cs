using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код создаёт объект - строитель, передаёт его директору,
            // а затем инициирует  процесс построения. Конечный результат
            // извлекается из объекта-строителя.
            var director = new Director();
            var builder = new ConcreteBuilder();
            var builder_1 = new ConcreteBuilder_1();
            director.Builder = builder;
            
            

            Console.WriteLine("Создать крышу:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Построить дом");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            director.Builder = builder_1;
            Console.WriteLine("Создать крышу:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder_1.GetProduct().ListParts());

            Console.WriteLine("Построить дом");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder_1.GetProduct().ListParts());

            // Помните, что паттерн Строитель можно использовать без класса
            // Директор.
            Console.WriteLine("создание частей");
            builder.BuildPartA();
            builder.BuildPartC();
            builder_1.BuildPartA();
            builder_1.BuildPartB();
            Console.Write(builder.GetProduct().ListParts());
            Console.Write(builder_1.GetProduct().ListParts());


        }
    }
}
