using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Poliedro.Billing.Application.ClientBillingElectronic.Commands.CreateClientBillingElectronic;
using Poliedro.Billing.Application.ClientBillingElectronic.Commands.DeleteClientBillingElectronic;
using Poliedro.Billing.Application.ClientBillingElectronic.Commands.UpdateClientBillingElectronic;
using Poliedro.Billing.Application.ClientBillingElectronic.Queries.GetAllClientBillingElectronic;
using Poliedro.Billing.Application.ClientBillingElectronic.Queries.GetClientBillingElectronicById;
using Poliedro.Billing.Application.Common.Exeptions;
using Poliedro.Billing.Application.Common.Features;
using Swashbuckle.AspNetCore.Annotations;

namespace Poliedro.Billing.Api.Controllers.v1.ClientBillingElectronic
{
    /// <summary>
    /// Controller for handling client billing electronic operations.
    /// </summary>
    [Route("api/v1/clientbillingelectronic")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class ClientBillingElectronicController(IMediator mediator) : ControllerBase
    {
        /// <summary>
        /// Creates a new client billing electronic record.
        /// </summary>
        /// <param name="createClientBillingElectronicCommand">The command to create the client billing electronic record.</param>
        /// <param name="validator">The validator for validating the command.</param>
        /// <returns>A status code indicating the result of the operation.</returns>
        /// <response code="201">Returns when the resource is successfully created.</response>
        /// <response code="400">Returns when the request data is invalid.</response>
        /// <response code="404">Returns when the resource could not be created.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status201Created,
            Description = "Client Billing Electronic created")]
        public async Task<ActionResult> Create(
            [FromBody] CreateClientBillingElectronicCommand createClientBillingElectronicCommand,
            [FromServices] IValidator<CreateClientBillingElectronicCommand> validator)
        {
            var validate = await validator.ValidateAsync(createClientBillingElectronicCommand);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            var result = await mediator.Send(createClientBillingElectronicCommand);
            if (!result)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created));
        }

        /// <summary>
        /// Updates an existing client billing electronic record.
        /// </summary>
        /// <param name="updateClientBillingElectronicCommand">The command to update the client billing electronic record.</param>
        /// <param name="validator">The validator for validating the command.</param>
        /// <returns>A status code indicating the result of the operation.</returns>
        /// <response code="200">Returns when the resource is successfully updated.</response>
        /// <response code="400">Returns when the request data is invalid.</response>
        /// <response code="404">Returns when the resource could not be found.</response>
        [HttpPut]
        public async Task<IActionResult> Update(
            [FromBody] UpdateClientBillingElectronicCommand updateClientBillingElectronicCommand,
            [FromServices] IValidator<UpdateClientBillingElectronicCommand> validator)
        {
            var validate = await validator.ValidateAsync(updateClientBillingElectronicCommand);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            var result = await mediator.Send(updateClientBillingElectronicCommand);
            if (!result)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK));
        }

        /// <summary>
        /// Retrieves all client billing electronic records.
        /// </summary>
        /// <returns>A status code indicating the result of the operation and the list of client billing electronic records.</returns>
        /// <response code="200">Returns the list of client billing electronic records.</response>
        /// <response code="404">Returns when there are no client billing electronic records found.</response>
        /// <response code="500">Returns when there is an internal server error.</response>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await mediator.Send(new GetAllClientBillingElectronicQuery());
            if (result == null || !result.Any())
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));
            }

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, result));
        }

        /// <summary>
        /// Get a Server register by ID
        /// </summary>
        /// <param name="id">ID to get a single ClientBillingElectronic.</param>
        /// <returns>A status code indicating the result of the operation.</returns>
        /// <response code="200">Returns when the resource is successfully.</response>
        /// <response code="400">Returns when the request data is invalid.</response>
        /// <response code="404">Returns when the resource could not be found.</response>
        /// <response code="500">Returns when there is an internal ClientBillingElectronic error.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            var getClientBillintElectronicQuery = new GetClientBillingElectronicByIdQuery { Id = id };
            var result = await mediator.Send(getClientBillintElectronicQuery);
            if (result == null)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, result));
        }

        /// <summary>
        /// Delete a ClientBillingElectronic register by ID
        /// </summary>
        /// <param name="id">ID to get a single ClientBillingElectronic.</param>
        /// <returns>A status code indicating the result of the operation.</returns>
        /// <response code="200">Returns when the resource is Delete.</response>
        /// <response code="400">Returns when the request data is invalid.</response>
        /// <response code="404">Returns when the resource could not be found.</response>
        /// <response code="500">Returns when there is an internal ClientBillingElectronic error.</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            var deleteClientBillintElectronicCommand = new DeleteClientBillingElectronicCommand { Id = id };
            var result = await mediator.Send(deleteClientBillintElectronicCommand);

            if (!result)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, result));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, result));
        }
    }
}
