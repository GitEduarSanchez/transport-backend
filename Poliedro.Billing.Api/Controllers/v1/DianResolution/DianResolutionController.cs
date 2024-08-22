using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Poliedro.Billing.Application.Common.Features;
using Poliedro.Billing.Application.DianResolution.Commands.CreateDianResolution;
using Poliedro.Billing.Application.DianResolution.Commands.DeleteDianResolution;
using Poliedro.Billing.Application.DianResolution.Queries.GetAllDianResolution;
using Poliedro.Billing.Application.DianResolution.Queries.GetSingleDianResolution;
using Poliedro.Billing.Application.Resolution.Dtos;
using Swashbuckle.AspNetCore.Annotations;

namespace Poliedro.Billing.Api.Controllers.v1.Server
{
    /// <summary>
    /// Controller for handling DIAN resolution operations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DianResolutionController(IMediator mediator) : ControllerBase
    {
        /// <summary>
        /// Creates a new DIAN resolution register.
        /// </summary>
        /// <param name="createDianResolutionCommand">Command to create a new Dian Resolution</param>
        /// <param name="validator">Command Validator</param>
        /// <returns>A status code indicating the result of the operation.</returns>
        /// <response code="201">Returns when the resource is successfully created.</response>
        /// <response code="400">Returns when the request data is invalid.</response>
        /// <response code="404">Returns when the resource could not be created.</response>

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status201Created,
            Description = "DIAN resolution register created")]
        public async Task<ActionResult> Create(
          [FromBody] CreateDianResolutionCommand createDianResolutionCommand,
          [FromServices] IValidator<CreateDianResolutionCommand> validator)
        {
            var validate = await validator.ValidateAsync(createDianResolutionCommand);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            var result = await mediator.Send(createDianResolutionCommand);
            if (!result)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created));
        }

        /// <summary>
        /// Retrieves all DIAN resolution registers.
        /// </summary>
        /// <returns>A status code indicating the result of the operation and the list of DIAN resolution registers.</returns>
        /// <response code="200">Returns the list of DIAN resolutions.</response>
        /// <response code="404">Returns when there are no DIAN resolutions found.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAll()
        {
            var data = await mediator.Send(new GetAllDianResolutionQuery());
            if (data == null || !data.Any())
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));
            }

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }

        /// <summary>
        /// Get a DIAN resolution register by ID
        /// </summary>
        /// <param name="id">ID to get a single DIAN resolution.</param>
        /// <returns>A status code indicating the result of the operation.</returns>
        /// <response code="200">Returns when the resource is successfully updated.</response>
        /// <response code="400">Returns when the request data is invalid.</response>
        /// <response code="404">Returns when the resource could not be found.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DianResolutionDto>> GetSingle(int id)
        {
            var data = await mediator.Send(new GetSingleDianResolutionQuery(id));
            if (data == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));
            }

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }

        /// <summary>
        /// Updates an existing DIAN resolution register.
        /// </summary>
        /// <param name="updateDianResolutionCommand">Command to update the DIAN resolution.</param>
        /// <param name="validator">The validator for validating the command.</param>
        /// <returns>A status code indicating the result of the operation.</returns>
        /// <response code="200">Returns when the resource is successfully updated.</response>
        /// <response code="400">Returns when the request data is invalid.</response>
        /// <response code="404">Returns when the resource could not be found.</response>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DianResolutionDto>> Update(
           int id,
           [FromBody] UpdateDianResolutionCommand updateDianResolutionCommand,
           [FromServices] IValidator<UpdateDianResolutionCommand> validator)
        {
            updateDianResolutionCommand = updateDianResolutionCommand with { id = id };
            var validate = await validator.ValidateAsync(updateDianResolutionCommand);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));


            var result = await mediator.Send(updateDianResolutionCommand);
            if (result is null)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, result));
        }

        /// <summary>
        /// Delete an existing DIAN resolution register.
        /// </summary>
        /// <param name="id">ID to delete a single DIAN resolution.</param>
        /// <param name="validator">The validator for validating the command.</param>
        /// <returns>A status code indicating the result of the operation.</returns>
        /// <response code="200">Returns when the resource is successfully deleted.</response>
        /// <response code="400">Returns when the request data is invalid.</response>
        /// <response code="404">Returns when the resource could not be found.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(
            int id,
            [FromServices] IValidator<DeleteDianResolutionCommand> validator)
        {
            var command = new DeleteDianResolutionCommand(id);
            var validate = await validator.ValidateAsync(command);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            var result = await mediator.Send(command);
            if (!result)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK));
        }
    }
}

