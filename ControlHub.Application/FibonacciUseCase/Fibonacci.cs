namespace ControlHub.Application.FibonacciUseCase
{
    public class Fibonacci : IFibonacci
    {
        public Fibonacci()
        {
        }

        public long CalcularFibonacci(int n)
        {
            return this.Calcular(n);
        }

        private long Calcular(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
            }
        }
    }
}
