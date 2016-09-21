using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_SpoonPool
{
    public class SingleSpoon
    {
        public static bool theSpoonIsAvailable=true;
        
        private static SingleSpoon instance = new SingleSpoon();

        private SingleSpoon() { }
        
        public static SingleSpoon getInstance()
        {
            theSpoonIsAvailable = true;
            showMessage();
            return instance;

        }
        public static void showMessage()
        {
            Console.WriteLine("The Spoon is available");
        }
    }
}
