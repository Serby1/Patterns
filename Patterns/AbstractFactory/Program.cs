using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
			Controller gcont = new Controller(new Germany.GermanyFactory());
			Controller ucont = new Controller(new USSR.USSR_Factory());

			// "Игра" USSR
			Console.WriteLine("Люди:");
			ucont.PlayGame();

			// "Игра" орков
			Console.WriteLine("\nОрки:");
			gcont.PlayGame();

			Console.Read();
		}
    }
}
