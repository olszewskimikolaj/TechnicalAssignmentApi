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

    [HttpGet]
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
