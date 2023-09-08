using ControlHub.Application.FibonacciUseCase;
using ControlHub.Entities.API.V1.Fibonacci;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlHub.Challange.Controllers.V1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ControlHubController : ControllerBase
    {

        private readonly ILogger<ControlHubController> _logger;
        private readonly IFibonacci _fibonacci;

        public ControlHubController(ILogger<ControlHubController> logger, IFibonacci fibonacci)
        {
            _logger = logger;
            _fibonacci = fibonacci;
        }

        [HttpPost]
        public IActionResult Fibonacci(FibonacciRequestDto request)
        {
            try
            {
                _logger.LogInformation($"Request recibido: {request.N}");

                var result = this._fibonacci.CalcularFibonacci(request.N);

                _logger.LogInformation($"Request procesado con exito: {request.N}");

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error procesando la solicitud: {ex.Message}");
                return BadRequest("Algo salio mal");
            }
        }
    }
}
