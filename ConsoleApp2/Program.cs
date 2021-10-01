using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = { 1, 2, 3, 4, 5, 6,-5,-4,0,0};
            Task1Algo t1 = new Task1Algo(p);
            t1.Find1(p);
        }
    }
}
