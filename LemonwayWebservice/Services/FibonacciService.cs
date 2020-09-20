using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LemonwayWebservice.Services
{
    public class FibonacciService : IFibonacciService
    {
        public async Task<int?> FibonacciAsync2(int n)
        {
           // await Task.Delay(2000);

            int Fib(int x)
            {
                int[] f = new int[x + 2];
                int i;
                f[0] = 0;
                f[1] = 1;
                for (i = 2; i <= x; i++)
                {
                    f[i] = f[i - 1] + f[i - 2];
                }
                return f[x];
            }

            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }
            
                return Fib(n - 1) + Fib(n - 2);
            
        }

        public async Task<int?> FibonacciAsync3(int n)
        {
            //await Task.Delay(2000);
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }
            
            if (n <0 || n > 100)
            {
                return -1;
            }
            
            
            return await FibonacciAsync3(n - 1) + await FibonacciAsync3(n - 2);
            
        }

        public int? FibonacciAsync(int n)
        {
            if (n <= 2)
            {
                // Base case of the recursive function.
                // i is either 1 or 2, whose associated Fibonacci sequence numbers are 1 and 1.
                return 1;
            }
            // Recursive case. Return the sum of the two previous Fibonacci numbers.
            // This works because the definition of the Fibonacci sequence specifies
            // that the sum of two adjacent elements equals the next element.
            return FibonacciAsync(n - 2) + FibonacciAsync(n - 1);

        }
    }
}