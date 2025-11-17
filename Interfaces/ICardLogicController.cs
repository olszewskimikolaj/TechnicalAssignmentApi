namespace TechnicalAssignmentApi.Interfaces;

public interface ICardLogicController
{
    public Task<List<string>> GetAllowedActions(string userId, string cardNumber);
}