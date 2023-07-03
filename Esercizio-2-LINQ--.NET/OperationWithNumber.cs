using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_2_LINQ__.NET
{
    internal class OperationWithNumber
    {

        public List<int> GenerateRandomNum(int num)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();
            for(int i = 0; i < num; i++)
            {
                int randomNum = random.Next();
                listInt.Add(randomNum);
                Console.WriteLine(listInt[i]);
            }
            return listInt; 
        }

        public void SelectUnevenNumb(List<int> list)
        {
            var unevenNum = list.
                Where(i => i % 2 != 0)
                .OrderBy(i => i);
            foreach(int i in unevenNum)     
                Console.WriteLine(i);
        }
    }
}
