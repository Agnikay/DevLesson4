using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Code
{
    public class Snack
    {
        public string Name { set; get; }
        public int Price { set; get; }
        public int Calories { set; get; }

        public override string ToString()
        {
            return String.Format("Name={0}, Price={1}, Calories={2}", Name, Price, Calories);
        }
    }
}
