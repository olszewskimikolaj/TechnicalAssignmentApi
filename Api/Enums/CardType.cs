namespace TechnicalAssignmentApi.Enums
{
    public enum CardType
    {
        Prepaid = 1 << 0,
        Debit = 1 << 1,
        Credit = 1 << 2
    }
}