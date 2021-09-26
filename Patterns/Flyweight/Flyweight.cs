using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
// Используем библиотеку Json.NET, загрузить можно через NuGet Package Manager
using Newtonsoft.Json;

namespace Flyweight
{
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
