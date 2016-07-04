using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Code
{
    public interface IDataProvider
    {
        string Seed { set; get; }
        string GetData();
    }
}
