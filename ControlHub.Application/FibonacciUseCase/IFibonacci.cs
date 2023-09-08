using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHub.Application.FibonacciUseCase
{
    public interface IFibonacci
    {
        long CalcularFibonacci(int n);
    }
}
