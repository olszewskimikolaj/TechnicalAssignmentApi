using Microsoft.AspNetCore.Mvc;
using TechnicalAssignmentApi.Interfaces;

namespace TechnicalAssignmentApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CardController : ControllerBase
{
    private readonly ICardLogicController _cardLogicController;
    private readonly ILogger<CardController> _logger;

    public CardController(ICardLogicController cardLogicController, ILogger<CardController> logger)
    {
        _cardLogicController = cardLogicController;
        _logger = logger;
    }

    /// <summary>
    /// Gets actions allowed for given user id and his card number based on card type and status
    /// </summary>
    /// <param name="userId">Selected user id</param>
    /// <param name="cardNumber">Selected user's card number</param>
    /// <returns>List of allowed actions for selected card of selected used, based on the kind and status of the card</returns>
    /// <response code="200">All allowed actions returned</response>
    /// <response code="500">An error occured when calling endpoint, no card actions were returned</response>
    [HttpGet]
    [ProducesResponseType(200)]
    [ProducesResponseType(500)]
    [Route("AllowedActions")]
    public async Task<IActionResult> GetAllowedActions(string userId, string cardNumber)
    {
        try
        {
            return Ok(await _cardLogicController.GetAllowedActions(userId, cardNumber));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(500);
        }
        
    }
}
