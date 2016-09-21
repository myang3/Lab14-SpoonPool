using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_SpoonPool
{
    public class SpoonPool
    {
        int single=0;
        SingleSpoon[] spoons = new SingleSpoon[4+1];
        public SpoonPool()
        {
            for (single = 0; single < 4; single++)

                SingleSpoon.getInstance();
        }

        public SingleSpoon release()
        {

            if (SingleSpoon.getInstance() == null)
            {
                Console.WriteLine("no more releases");
                
                return spoons[single--];
            }
            else
                Console.WriteLine("No More Spoons");
            
            return spoons[single];
          }
    }
}
