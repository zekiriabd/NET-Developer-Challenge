using System.Threading.Tasks;

namespace LemonwayWebservice.Services
{
    public interface IFibonacciService
    {
        int? FibonacciAsync(int n);
    }
}