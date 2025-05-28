using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFilter summ = new MyFilter();
            int[] arr = { -20, -5, 6, 15, 10 };
            summ.AmountOfArray(arr);

        }
    }
}
