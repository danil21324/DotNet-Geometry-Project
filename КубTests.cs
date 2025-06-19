using NUnit.Framework;
using GeometryLibrary;
using System;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class КубTests
    {
        // Тест 1: Перевірка коректного обчислення об'єму
        [Test]
        [TestCase(2.0, 8.0)]  // Сторона = 2, очікуваний об'єм = 8
        [TestCase(1.0, 1.0)]  // Сторона = 1, очікуваний об'єм = 1
        [TestCase(10.0, 1000.0)] // Сторона = 10, очікуваний об'єм = 1000
        public void ОбчислитиОбєм_ПриПозитивнійСтороні_ПовертаєПравильнийОбєм(double сторона, double expectedVolume)
        {
            // Arrange (Підготовка)
            Куб куб = new Куб(сторона);

            // Act (Дія)
            double actualVolume = куб.ОбчислитиОбєм();

            // Assert (Перевірка)
            Assert.AreEqual(expectedVolume, actualVolume, 0.001, "Об'єм обчислено невірно.");
        }

        // Тест 2: Перевірка коректного обчислення площі поверхні
        [Test]
        [TestCase(2.0, 24.0)] // Сторона = 2, очікувана площа = 6 * 4 = 24
        [TestCase(1.0, 6.0)]  // Сторона = 1, очікувана площа = 6
        [TestCase(5.0, 150.0)]// Сторона = 5, очікувана площа = 6 * 25 = 150
        public void ОбчислитиПлощуПоверхні_ПриПозитивнійСтороні_ПовертаєПравильнуПлощу(double сторона, double expectedArea)
        {
            // Arrange (Підготовка)
            Куб куб = new Куб(сторона);

            // Act (Дія)
            double actualArea = куб.ОбчислитиПлощуПоверхні();

            // Assert (Перевірка)
            Assert.AreEqual(expectedArea, actualArea, 0.001, "Площа поверхні обчислена невірно.");
        }

        // Тест 3: Перевірка, що конструктор генерує виняток для некоректних даних
        [Test]
        [TestCase(0)]
        [TestCase(-5.5)]
        public void Конструктор_ПриНульовійАбоВідємнійСтороні_КидаєВинятокArgumentException(double invalidSide)
        {
            // Arrange, Act & Assert
            // Перевіряємо, що при спробі створити куб з некоректною стороною
            // буде згенеровано виняток типу ArgumentException.
            Assert.Throws(() => new Куб(invalidSide), "Конструктор не згенерував виняток для некоректної сторони.");
        }
    }
}
