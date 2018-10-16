using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Architect.Test
{

    [TestClass]
    public class UnitTestArchitect
    {
        private Architect architect;

        [TestInitialize]
        public void TestInitialize()
        {
            architect = new Architect("Aurelia", "Grosu", DateTime.Now.AddDays(-6), DateTime.Now.AddDays(6), 180.90);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            architect = null;
        }

        [TestMethod]
        public void When_GetFullNameIsCalled_ThenShould_ReturnFullName()
        {
            var result = architect.GetFullName();

            result.Should().Be($"{architect.FirstName} {architect.LastName}");
        }

        [TestMethod]
        public void When_IsActiveIsCalled_ThenShould_ReturnFalseForInvalidDates()
        {
            var result = architect.IsActive();

            result.Should().BeFalse();
        }

        [TestMethod]
        public void When_IsActiveIsCalled_ThenShould_ReturnTrueForValidDates()
        {
            var result = architect.IsActive();

            result.Should().BeTrue();
        }

        [TestMethod]
        public void When_SalutationIsCalled_ThenShould_ReturnHelloArchitect()
        {
            var result = architect.Salutation();

            result.Should().Be($"Hello architect!");
        }
    }
}