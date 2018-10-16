using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employee.Test
{
    
    [TestClass]
    public class UnitTestManager
    {
        private Manager manager;

        [TestInitialize]
        public void TestInitialize()
        {
            manager = new Manager("Delia", "Arcana", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(6), 153.05);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            manager = null;
        }

        [TestMethod]
        public void When_GetFullNameIsCalled_ThenShould_ReturnFullName()
        {
            var result = manager.GetFullName();

            result.Should().Be($"{manager.FirstName} {manager.LastName}");
        }

        [TestMethod]
        public void When_IsActiveIsCalled_ThenShould_ReturnFalseForInvalidDates()
        {
            var result = manager.IsActive();

            result.Should().BeFalse();
        }

        [TestMethod]
        public void When_IsActiveIsCalled_ThenShould_ReturnTrueForValidDates()
        {
            var result = manager.IsActive();

            result.Should().BeTrue();
        }

        [TestMethod]
        public void When_SalutationIsCalled_ThenShould_ReturnHelloManager()
        {
            var result = manager.Salutation();

            result.Should().Be($"Hello manager!");
        }
    }
}