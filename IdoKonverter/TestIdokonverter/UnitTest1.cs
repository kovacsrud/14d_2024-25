using IdoKonverter;

namespace TestIdokonverter
{
    public class Tests
    {
        //A tesztel�s elej�n lefut� met�dus
        [SetUp]
        public void Setup()
        {
        }

        //Teszt met�dus
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