using lab3.Interfaces;
namespace lab3.Services
{
    public class CalculatorService: ICalculatorService
    {
        public Single GetSum(Single a, Single b)
        {
            return a + b;
        }
        public Single GetSubtraction(Single a, Single b)
        {
            return a - b;
        }
        public Single GetMultiplication(Single a, Single b)
        {
            return a * b;
        }
        public Single GetDevision(Single a, Single b)
        {
            return a / b;
        }
    }
}