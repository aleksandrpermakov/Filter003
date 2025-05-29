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
            
           string fileName = FSWorker.ReadAllFile(args[0]); 
            List<int> arr = new List<int>();
            foreach (var item in fileName.Split(' '))
            {
                int i = 0;
                if(int.TryParse(item, out i))
                {
                    arr.Add(i);
                }
            }
           
            summ.AmountOfArray(arr.ToArray());
        }
    }
}
