
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loanDeport
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            total = Enumerable.Range(0, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            Console.WriteLine("The sum is : {0}\n", total);
            Console.ReadLine();
        }
    }
}
