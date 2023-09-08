using System;
using System.ComponentModel.DataAnnotations;

namespace ControlHub.Entities.API.V1.Fibonacci
{
    public class FibonacciRequestDto
    {
        [Required]
        public int N { get; set; }
    }
}
