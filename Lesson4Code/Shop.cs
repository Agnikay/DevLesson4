using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Code
{
    public class Shop
    {
        public Shop()
        {
            Snacks = new List<Snack>()
            {
                new Snack() {Name = "Bounty", Calories = 400, Price = 12 },
                new Snack() {Name = "Pahlava", Calories = 600, Price = 20 },
                new Snack() {Name = "Shawerma", Calories = 700, Price = 25},
                new Snack() {Name = "Semochki", Calories = 256, Price = 5 },
                new Snack() {Name = "Brezeli", Calories = 340, Price = 10 },
                new Snack() {Name = "Donut", Calories = 600, Price = 20 }
            };
        }

        public List<Snack> Snacks;
    }
}
