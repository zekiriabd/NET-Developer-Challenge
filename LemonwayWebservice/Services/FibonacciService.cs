using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace LemonwayWebservice.Services
{
    public class FibonacciService : IFibonacciService
    {
        public decimal Fibonacci(int n)
        {
            Thread.Sleep(2000);
            
            if (n < 1 || n > 100) { return -1; }

            decimal[] fib = new decimal[n + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            return fib[n];
        }
    }
}