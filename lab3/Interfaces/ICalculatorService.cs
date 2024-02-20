namespace lab3.Interfaces
{
    interface ICalculatorService
    {
        Single GetSum(Single a, Single b);
        Single GetSubtraction(Single a, Single b);
        Single GetMultiplication(Single a, Single b);
        Single GetDevision(Single a, Single b);
    }
}