using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBottles
{
    public class NewBottles
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number Bottle : ");
            int numBottle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number Exchange : ");
            int numExchange = Convert.ToInt32(Console.ReadLine());
            int tot = Bottles(numBottle, numExchange);
            Console.WriteLine("Total Water Bottles : " + tot);
        }

        public static int Bottles(int numBottle, int numExchange)
        {
            int tot = numBottle; 
            int empty = numBottle;

            while (empty >= numExchange)
            {
                
                int newBottles = empty / numExchange;
                empty = empty % numExchange;
                tot += newBottles;
                empty += newBottles;
            }

            return tot;
        }
    }
}
