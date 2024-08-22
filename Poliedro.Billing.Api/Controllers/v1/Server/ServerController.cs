using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Poliedro.Billing.Application.Common.Exeptions;
using Poliedro.Billing.Application.Common.Features;
using Poliedro.Billing.Application.Server.Commands.CreateServerCommand;
using Poliedro.Billing.Application.Server.Queries.GellAllServer;
using Swashbuckle.AspNetCore.Annotations;

namespace Poliedro.Billing.Api.Controllers.v1.Server
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class ServerController(IMediator mediator,
        IValidator<CreateServerCommand> validator) : ControllerBase
    {
        /// <summary>
        /// Retrieves all client billing electronic records.
        /// </summary>
        /// <returns>A status code indicating the result of the operation and the list of client billing electronic records.</returns>
        /// <response code="200">Returns the list of client billing electronic records.</response>
        /// <response code="404">Returns when there are no client billing electronic records found.</response>
        /// <response code="500">Returns when there is an Internal Server Error.</response>
        [HttpGet]        
        public async Task<IActionResult> GetAll()
        {
            var data = await mediator.Send(new GellAllServerQuery());
            if (data == null || !data.Any())
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));
            }

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost]
                
        public async Task<IActionResult> Create([FromBody] CreateServerCommand command)
        {
            var validationResult = await ValidateCommandAsync(command);
            if (!validationResult.IsValid)
            {
                return HandleValidationErrors(validationResult.Errors);
            }
            await mediator.Send(command);
            return CreatedAtAction(null, null);
        }
       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CreateServerCommand command)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private async Task<FluentValidation.Results.ValidationResult> ValidateCommandAsync(CreateServerCommand command)
        {
            return await validator.ValidateAsync(command);
        }

        private IActionResult HandleValidationErrors(List<ValidationFailure> errors)
        {
            GetErrorValidator(errors);
            return BadRequest(errors);
        }

        private static void GetErrorValidator(List<ValidationFailure> failures)
        {
            foreach (var failure in failures)
            {
                Console.WriteLine($"log: {failure.ErrorMessage}");
            }
        }
    }
}
