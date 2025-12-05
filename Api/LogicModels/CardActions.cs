using TechnicalAssignmentApi.Attributes;
using TechnicalAssignmentApi.Builders;
using TechnicalAssignmentApi.Interfaces;
using TechnicalAssignmentApi.Models;

namespace TechnicalAssignmentApi.LogicModels
{
    public class CardActions
    {
        private readonly IList<ICardActionsValidator> _cardActionsValidator;

        public CardActions(CardDetails cardDetails)
        {
            _cardActionsValidator = new CardActionsValidatorBuilder()
                                    .AddCardActionsByCardKindValidator(cardDetails.CardType)
                                    .AddCardActionsByCardStatusAndPinValidator(cardDetails.CardStatus, cardDetails.IsPinSet)
                                    .Build();
        }

        [CardAction]
        public bool Action1
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action1();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action2
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action2();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action3
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action3();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action4
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action4();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action5
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action5();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action6
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action6();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action7
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action7();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action8
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action8();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action9
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action9();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action10
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action10();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action11
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action11();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action12
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action12();
                }
                return allowed;
            }
        }

        [CardAction]
        public bool Action13
        {
            get
            {
                bool allowed = true;
                foreach (var validator in _cardActionsValidator)
                {
                    allowed &= validator.Action13();
                }
                return allowed;
            }
        }
    }
}