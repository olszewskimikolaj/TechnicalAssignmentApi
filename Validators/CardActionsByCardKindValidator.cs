using TechnicalAssignmentApi.Enums;
using TechnicalAssignmentApi.Interfaces;

namespace TechnicalAssignmentApi.Validators;

public class CardActionsByCardKindValidator() : ICardActionsValidator
{
    private readonly CardType _cardType;

    public CardActionsByCardKindValidator(CardType cardType) : this()
    {
        _cardType = cardType;
    }

    public bool Action1()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action2()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action3()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action4()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action5()
    {
        return _cardType == CardType.Credit;
    }

    public bool Action6()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action7()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action8()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action9()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action10()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action11()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action12()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    public bool Action13()
    {
        return AllCardTypes.HasFlag(_cardType);
    }

    private CardType AllCardTypes => CardType.Prepaid | CardType.Debit | CardType.Credit;
}