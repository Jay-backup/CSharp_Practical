using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.LSP
{
    public class Sum
    {
        protected readonly int[] _numbers;

        public Sum(int[] numbers)
        {
            _numbers = numbers;
        }

        public virtual int Calculate() => _numbers.Sum();
    }
    public class SumOdd : Sum
    {
        public SumOdd(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Where(x => x % 2 != 0).Sum();
        
    }
    public class EvenNumbersSumCalculator : Sum
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        } 
    }

    class After_LSP
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            Sum calc = new Sum(numbers);
            Console.WriteLine($"The sum of all the numbers: {calc.Calculate()}");
            Console.WriteLine();

            calc = new SumOdd(numbers);
            Console.WriteLine($"The sum of all the odd numbers: {calc.Calculate()}");

            calc = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {calc.Calculate()}");
        }
   
    }
}
