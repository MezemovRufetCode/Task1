using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Task1Algo
    {
        public int[] Arr;
        public Task1Algo(int[] arr)
        {
            Arr=arr;
        }
        public void Find1(int[] array)
        {           
            int countmin = 0;
            int countplus = 0;
            int countzero = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    countzero++;
                }
                else
                if (array[i] %2== 0)
                {
                    countplus++;
                }
                else
                    countmin++;
            }
            Console.WriteLine($"Count of zero: {countzero}\nCount of negative: {countmin}\nCount of positive: {countplus}");

        }
    }
}
