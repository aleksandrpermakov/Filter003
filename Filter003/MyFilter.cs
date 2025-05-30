using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter003
{
    internal class MyFilter
    {
        public int AmountOfArray11(int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                if (item < (-10) || item > 10)
                {
                    result += item;
                }
            }
            //Console.WriteLine(result);
            return result ;
        }
        public string NumbersOfArray11(int[] array)
        {
            string result = string.Empty;

            foreach (var item in array)
            {
                if (item < (-10) || item > 10)
                {
                    result += item + " ";
                }
            }

            return result + '\n' + '\r';
        }
    }
}
