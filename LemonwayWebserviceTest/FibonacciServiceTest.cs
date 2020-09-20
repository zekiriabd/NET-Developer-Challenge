using System;
using System.Threading.Tasks;
using LemonwayWebservice.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonwayWebserviceTest
{
    [TestClass]
    public class FibonacciServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FibonacciService fibonacciService = new FibonacciService();
            Assert.IsTrue(fibonacciService.Fibonacci(1) == 1);
            Assert.IsTrue(fibonacciService.Fibonacci(2) == 1);
            Assert.IsTrue(fibonacciService.Fibonacci(3) == 2);
            Assert.IsTrue(fibonacciService.Fibonacci(4) == 3);
            Assert.IsTrue(fibonacciService.Fibonacci(6) == 8);
            Assert.IsTrue(fibonacciService.Fibonacci(-101) == -1);
            Assert.IsTrue(fibonacciService.Fibonacci(1000) == -1);
        }


    }
}
