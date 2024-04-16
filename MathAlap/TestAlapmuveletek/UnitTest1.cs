using MathAlap;

namespace TestAlapmuveletek
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //[TestCase(300,200,100)]
        //[TestCase(400, 200, 200)]
        //[TestCase(700, 400, 300)]
        //[TestCase(500.3456788,250.35,250)]
        [TestCaseSource("GetOsszeadasAdatok")]
        public void OsszeadasTest(double elvart,double a,double b)
        {
            //Három rész arrange, act, assert (AAA)

            //arrange: elõkészületek
            //act: mûvelet, mûveletek elvégzése
            //assert: a kapott eredmény kiértékelése

            //arrange
            Alapmuveletek alapmuveletek = new Alapmuveletek();

            //act
            var eredmeny = alapmuveletek.Osszeadas(a, b);

            //assert
            Assert.AreEqual(elvart, eredmeny,0.01);
        }

        public static IEnumerable<double[]> GetOsszeadasAdatok()
        {
            var sorok = File.ReadAllLines("tesztesetek_osszeadas.csv");
            for (int i = 0; i < sorok.Length; i++)
            {
                var adatok = sorok[i].Split(';');
                double a = Convert.ToDouble(adatok[0]);
                double b = Convert.ToDouble(adatok[1]);
                double elvart = Convert.ToDouble(adatok[2]);

                yield return new[] { elvart, a, b };
            }
        }

    }
}