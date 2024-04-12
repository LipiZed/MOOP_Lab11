using MOOP_Lab11;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Tests
{
    [TestFixture]
    public class DecoratorPatternTests
    {
        [Test]
        public void TestCheeseDecorator()
        {
            Sandwich sandwich = new Cheese(new Bread());
            Assert.That(sandwich.Price, Is.EqualTo(20));
            Assert.That(sandwich.Description, Is.EqualTo("Хлеб, сыр"));
        }

        [Test]
        public void TestMushroomsDecorator()
        {
            Sandwich sandwich = new Mushrooms(new Bread());
            Assert.That(sandwich.Price, Is.EqualTo(25));
            Assert.That(sandwich.Description, Is.EqualTo("Хлеб, грибы"));
        }

        [Test]
        public void TestCheeseAndMushroomsDecorator()
        {
            Sandwich sandwich = new Mushrooms(new Cheese(new Bread()));
            Assert.That(sandwich.Price, Is.EqualTo(35));
            Assert.That(sandwich.Description, Is.EqualTo("Хлеб, сыр, грибы"));
        }

        [Test]
        public void TestVegetablesDecorator()
        {
            Sandwich sandwich = new Vegetables(new Bread());
            Assert.That(sandwich.Price, Is.EqualTo(30));
            Assert.That(sandwich.Description, Is.EqualTo("Хлеб, овощи"));
        }
    }
}
