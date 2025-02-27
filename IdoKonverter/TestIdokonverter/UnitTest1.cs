using IdoKonverter;

namespace TestIdokonverter
{
    public class Tests
    {
        //A tesztelés elején lefutó metódus
        [SetUp]
        public void Setup()
        {
        }

        //Teszt metódus
        [Test]
        [TestCase(3600,1)]
        [TestCase(7200, 2)]
        public void HourToSecTest(int elvart,int hour)
        {
            //AAA - Arrange,Act,Assert
            var eredmeny = Idokonverter.HourToSec(hour);

            Assert.AreEqual(elvart,eredmeny);
        }
    }
}