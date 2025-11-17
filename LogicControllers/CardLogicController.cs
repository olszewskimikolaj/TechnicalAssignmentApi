using TechnicalAssignmentApi.Attributes;
using TechnicalAssignmentApi.Interfaces;
using TechnicalAssignmentApi.LogicModels;

namespace TechnicalAssignmentApi.LogicControllers;

public class CardLogicController : ICardLogicController
{
    private readonly ICardService _cardService;

    public CardLogicController(ICardService cardService)
    {
        _cardService = cardService;
    }

    public async Task<List<string>> GetAllowedActions(string userId, string cardNumber)
    {
        var card = await _cardService.GetCardDetails(userId, cardNumber);

        if(card == null)
        {
            return new List<string>();
        }

        var cardActions = new CardActions(card);

        return typeof(CardActions)
                        .GetProperties()
                        .Where(p => Attribute.IsDefined(p, typeof(CardActionAttribute)))
                        .Where(p => p.PropertyType == typeof(bool))
                        .Where(p => (bool)p.GetValue(cardActions) == true)
                        .Select(p => p.Name)
                        .ToList();
    }
}