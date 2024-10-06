using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Poliedro.Billing.Application.CategoriaDocumento.Commands;
using Poliedro.Billing.Application.CategoriaDocumento.Dto;
using Poliedro.Billing.Application.CategoriaDocumento.Query;

namespace Poliedro.Billing.Api.Controllers.CategoriaDocumento
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaDocumentoController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<CategoriaDocumentoDto>> GetAll()
        {
            return await mediator.Send(new GetAllActuatorsQuery());
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        [HttpPost]
        public async Task<ActionResult<bool>> Create([FromBody] CreateCategoriaDocumentoCommand command)
        {
            await mediator.Send(command);
            return CreatedAtAction(null, null);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CreateCategoriaDocumentoCommand command)
        {}

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

        private IActionResult HandleValidationErrors(List<ValidationFailure> errors)
        {
            GetErrorValidator(errors);
            return BadRequest(errors);
        }

        private void GetErrorValidator(List<ValidationFailure> errors)
        {
            foreach (var error in errors)
            {
                Console.WriteLine($"log: {error.ErrorMessage}");
            }
        }
    }
}
