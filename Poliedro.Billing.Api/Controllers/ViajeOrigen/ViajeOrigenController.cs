using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Poliedro.Billing.Application.Common.Exeptions;
using Poliedro.Billing.Application.ViajeOrigen.Commands.CreateServerCommand;
using Poliedro.Billing.Application.ViajeOrigen.Dto;
using Poliedro.Billing.Application.ViajeOrigen.Query;

namespace Poliedro.Billing.Api.Controllers.v1.Server
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class ViajeOrigenController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<ViajeOrigenDto>> GetAll()
        {
            return await mediator.Send(new GetAllViajeOrigenQuery());
        }
        [HttpGet("{id}")]
        public async Task<ConceptoDto> GetAsync([FromRoute] int id)
        {
            var getConductorByIdQuery = new GetByIdConceptoQuery(id);
            return await mediator.Send(getConceptoByIdQuery);
        }


        [HttpPost]
                
        public async Task<ActionResult<bool>> Create([FromBody] CreateViajeOrigenCommand command)
        {
            await mediator.Send(command);
            return CreatedAtAction(null, null);
        }
       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CreateViajeOrigenCommand command)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
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
