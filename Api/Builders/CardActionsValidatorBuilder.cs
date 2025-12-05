using TechnicalAssignmentApi.Enums;
using TechnicalAssignmentApi.Interfaces;
using TechnicalAssignmentApi.Validators;

namespace TechnicalAssignmentApi.Builders
{
    public class CardActionsValidatorBuilder
    {
        private IList<ICardActionsValidator> _cardActionsValidators = new List<ICardActionsValidator>();

        public CardActionsValidatorBuilder AddCardActionsByCardKindValidator(CardType cardType)
        {
            _cardActionsValidators.Add(new CardActionsByCardKindValidator(cardType));
            return this;
        }

        public CardActionsValidatorBuilder AddCardActionsByCardStatusAndPinValidator(CardStatus cardStatus, bool isPinSet)
        {
            _cardActionsValidators.Add(new CardActionsByCardStatusAndPinValidator(cardStatus, isPinSet));
            return this;
        }

        public IList<ICardActionsValidator> Build()
        {
            return _cardActionsValidators;
        }
    }
}