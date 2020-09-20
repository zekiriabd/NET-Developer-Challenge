using System;
using System.Threading.Tasks;

namespace LemonwayWebservice.Services
{
    public interface IFibonacciService
    {
        decimal Fibonacci(int n);
    }
}