using TechnicalAssignmentApi.Enums;
using TechnicalAssignmentApi.Interfaces;

namespace TechnicalAssignmentApi.Validators;

public class CardActionsByCardStatusAndPinValidator() : ICardActionsValidator
{
    private readonly CardStatus _cardStatus;
    private readonly bool _isPinSet;

    public CardActionsByCardStatusAndPinValidator(CardStatus cardStatus, bool isPinSet) : this()
    {
        _cardStatus = cardStatus;
        _isPinSet = isPinSet;
    }

    public bool Action1()
    {
        return _cardStatus == CardStatus.Active;
    }

    public bool Action2()
    {
        return _cardStatus == CardStatus.Inactive;
    }

    public bool Action3()
    {
        return AllCardStatuses.HasFlag(_cardStatus);
    }

    public bool Action4()
    {
        return AllCardStatuses.HasFlag(_cardStatus);
    }

    public bool Action5()
    {
        return AllCardStatuses.HasFlag(_cardStatus);
    }

    public bool Action6()
    {
        return (CardStatus.Ordered | CardStatus.Inactive | CardStatus.Active | CardStatus.Blocked).HasFlag(_cardStatus) && _isPinSet;
    }

    public bool Action7()
    {
        return ((CardStatus.Ordered | CardStatus.Inactive | CardStatus.Active).HasFlag(_cardStatus) && !_isPinSet) 
                    || (_cardStatus == CardStatus.Blocked && _isPinSet);
    }

    public bool Action8()
    {
        return (CardStatus.Ordered | CardStatus.Inactive | CardStatus.Active | CardStatus.Blocked).HasFlag(_cardStatus);
    }

    public bool Action9()
    {
        return AllCardStatuses.HasFlag(_cardStatus);
    }

    public bool Action10()
    {
        return (CardStatus.Ordered | CardStatus.Inactive | CardStatus.Active).HasFlag(_cardStatus);
    }

    public bool Action11()
    {
        return (CardStatus.Inactive | CardStatus.Active).HasFlag(_cardStatus);
    }

    public bool Action12()
    {
        return (CardStatus.Ordered | CardStatus.Inactive | CardStatus.Active).HasFlag(_cardStatus);
    }

    public bool Action13()
    {
        return (CardStatus.Ordered | CardStatus.Inactive | CardStatus.Active).HasFlag(_cardStatus);
    }

    private CardStatus AllCardStatuses => CardStatus.Ordered | CardStatus.Inactive | CardStatus.Active | CardStatus.Restricted | CardStatus.Blocked | CardStatus.Expired | CardStatus.Closed;
}