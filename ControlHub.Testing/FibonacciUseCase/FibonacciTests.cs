using ControlHub.Application.FibonacciUseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ControlHub.Testing.FibonacciUseCase
{
        public class FibonacciTests
        {
            [Fact]
            public void CalcularFibonacci_CuandoNesCero_DebeDevolverCero()
            {
                // Arrange
                var fibonacci = new Fibonacci();
                int n = 0;

                // Act
                long resultado = fibonacci.CalcularFibonacci(n);

                // Assert
                Assert.Equal(0, resultado);
            }

            [Fact]
            public void CalcularFibonacci_CuandoNesUno_DebeDevolverUno()
            {
                // Arrange
                var fibonacci = new Fibonacci();
                int n = 1;

                // Act
                long resultado = fibonacci.CalcularFibonacci(n);

                // Assert
                Assert.Equal(1, resultado);
            }

            [Fact]
            public void CalcularFibonacci_CuandoNesDiez_DebeDevolverElValorCorrecto()
            {
                // Arrange
                var fibonacci = new Fibonacci();
                int n = 10;

                // Act
                long resultado = fibonacci.CalcularFibonacci(n);

                // Assert
                Assert.Equal(55, resultado);
            }
        }
}
