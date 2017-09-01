using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRComputeMaxDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }

    class Difference {
        //variables
        private int[] elements;

        public int maximumDifference;
        //constructor
        public Difference(int[] a)
        {
        this.elements= a;
        }
        public void computeDifference()
        {
            int min = elements[0];
            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                min = Math.Min(min, elements[i]);
                max = Math.Max(max, elements[i]);
            }
            this.maximumDifference = Math.Abs(max - min);
        }
    }
}
