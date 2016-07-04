using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Code
{
    public class RandomDataProvider : IDataProvider
    {
        public string Seed
        {
            get
            {
                return "Random1";
            }

            set
            {
                
            }
        }

        public string GetData()
        {
            return "Test Data";
        }
    }
}
