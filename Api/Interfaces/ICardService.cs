using TechnicalAssignmentApi.Models;

namespace TechnicalAssignmentApi.Interfaces;

public interface ICardService
{
    public Task<CardDetails?> GetCardDetails(string userId, string cardNumber);
}