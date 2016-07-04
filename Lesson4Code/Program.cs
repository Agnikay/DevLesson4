using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson4Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambdas
            int i = 42;
            Action act = () => Console.WriteLine("Hello from Lambda " + i);
            Func<int, int, bool> func = (a, b) => a > b;
            Func<int, int, bool> func2 = (a, b) => a < b;
            Func<int, int, bool> func3 = (a, b) => a == b;

            Action<string> actHello = (name) => 
            {
                string greeting = "Hello " + name;
                Console.WriteLine(greeting);
                ExecuteMath(func);
                ExecuteMath(func2);
                ExecuteMath(func3);
            };


            actHello("Vasya");

            //Var example
            var j = 5;
            var s = "Some string";
            var res = GetSomething();


            //Anonymous classes
            var someValue = new { Title = "Game of Thrones", Duration = 45 };
            Console.WriteLine(someValue.GetType().Name);
            Console.WriteLine(someValue.Duration + someValue.Title);

            //Extension methods
            int some = 23;
            some.IsMyFavoriteInt();

            RandomDataProvider dataProvider = new RandomDataProvider();
            dataProvider.GetNewData("From Main");

            Console.WriteLine("************LINQ***************");
            Console.WriteLine();
            //LINQ
            Shop shop = new Shop();
            var allSnacks = from snack in shop.Snacks select snack;
            foreach (var snack in allSnacks)
            {
                Console.WriteLine(snack);
            }

            var filtered = from snack in shop.Snacks where snack.Price < 10 select snack;
            var snacksNames = from snack in shop.Snacks where snack.Price < 20 select snack.Name;
            var lovelySnacks = from snack in shop.Snacks where (snack.Price < 30 && snack.Calories < 400) select "I love " + snack.Name;
            var cutSnacks = from snack in shop.Snacks where snack.Name.Length > 5 select new {snack.Name, snack.Price };

            var snacksMethod = shop.Snacks.Where(snack => snack.Price < 10);
            var canIEatSomething = shop.Snacks.Any(snack => snack.Price < 20 && snack.Calories < 200);
            var average = shop.Snacks.Average(snack => snack.Price);            

            Console.ReadLine();
        }

        private static Dictionary<string, List<IEnumerable<Object>>> GetSomething()
        {
            var result = new Dictionary<string, List<IEnumerable<Object>>>();
            return null;
        }

        static void Execute(Action action)
        {
            action();
        }

        static void ExecuteMath(Func<int, int, bool> func)
        {
            Console.WriteLine("a func b = " + func(12, 54));
        }
    }
}
