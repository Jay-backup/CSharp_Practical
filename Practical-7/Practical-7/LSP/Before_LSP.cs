using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.LSP
{
    public class SumsCalculator
    {
        protected readonly int[] _numbers;

        public SumsCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate() => _numbers.Sum();
        
    }

    public class EvenNumberSumCalculator : SumCalculator
    {
        public EvenNumberSumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public new int Calculate()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }

    class Before_LSP
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            SumsCalculator sum = new SumsCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Console.WriteLine();

            SumCalculator evenSum = new EvenNumberSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
        }
    }
}
