using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_SpoonPool
{
    public class Spoons
    {
        static void Main(string[] args)
        {
            SpoonPool sp = new SpoonPool();
            sp.release();
            Console.ReadLine();
        }
    }
}
