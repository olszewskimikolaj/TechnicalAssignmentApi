using Moq;
using TechnicalAssignmentApi.Enums;
using TechnicalAssignmentApi.Interfaces;
using TechnicalAssignmentApi.LogicControllers;
using TechnicalAssignmentApi.Models;

namespace ApiTests.LogicControllersTests
{
    internal class CardLogicControllerTests
    {
        private Mock<ICardService> _cardService;
        private ICardLogicController _cardLogicController;

        [SetUp]
        public void Setup()
        {
            _cardService = new Mock<ICardService>();
            _cardLogicController = new CardLogicController(_cardService.Object);
        }

        [Test]
        public async Task GetAllowedActions_ReturnNoActions()
        {
            CardDetails card = null;

            _cardService
                .Setup(x => x.GetCardDetails(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(card);

            var result = await _cardLogicController.GetAllowedActions("User1", "Card1");

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        }

        [TestCase(CardType.Debit, CardStatus.Ordered, true, true)]
        [TestCase(CardType.Debit, CardStatus.Ordered, false, false)]
        [TestCase(CardType.Debit, CardStatus.Restricted, false, false)]
        [TestCase(CardType.Prepaid, CardStatus.Blocked, true, true)]
        [TestCase(CardType.Prepaid, CardStatus.Expired, false, false)]
        public async Task GetAllowedActions_AllowedActionsContainAction6(CardType cardType, CardStatus cardStatus, bool isPinSet, bool action6Allowed)
        {
            CardDetails card = new CardDetails("Card1", cardType, cardStatus, isPinSet);

            _cardService
                .Setup(x => x.GetCardDetails(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(card);

            var result = await _cardLogicController.GetAllowedActions("User1", "Card1");

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Contains("Action6"), Is.EqualTo(action6Allowed));
        }
    }
}
