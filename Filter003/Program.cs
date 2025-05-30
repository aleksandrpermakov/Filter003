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

            string fileName = FSWorker.ReadAllFile(args[0]);//"-20 -5 5 15 25 100";
            List<int> arr = new List<int>();
            foreach (var item in fileName.Split(' '))
            {
                int i = 0;
                if (int.TryParse(item, out i))
                {
                    arr.Add(i);
                }
            }

            string summ_ = summ.AmountOfArray11(arr.ToArray()).ToString() ;
            string numbers_ = summ.NumbersOfArray11(arr.ToArray());
            string fileNameSumm = FSWorker.GetPathMyDocuments() + @"\summ.txt";
            string fileNameNumbers = FSWorker.GetPathMyDocuments() + @"\numbers.txt";
            FSWorker.WriteToFile(fileNameSumm, summ_ + '\n' + '\r');
            FSWorker.WriteToFile(fileNameNumbers, numbers_);
            // Console.WriteLine(FSWorker.GetPathMyDocuments()); //C:\Users\Алекс\Documents

        }
    }
}
