using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrishnaMurthyNo
{
    internal class KrishnaMurthyNo
    {
        public static void Main(string[] args)
        {
            int n = 145;
            int temp = n;
            int sum = 0;
            while (temp != 0) {
                int res = temp % 10;
                sum += Fact(res);
                temp /= 10;
            }
            if(n == sum)
            {
                Console.WriteLine("Krishna Murthy Number");
            } else {
                Console.WriteLine("Not a Krishna Murthy Number");
            }
        }
        
        public static int Fact(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++) { 
                fact = fact * i;
                
            }
            return fact;
        }
    }
}
