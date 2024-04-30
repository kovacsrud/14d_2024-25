using KRHash;

namespace TestHash
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        [TestCase("Valami, bármi, akármi", "43143ff9ff5b82d9ed1627019659440a")]
        public void Md5HashTest(string szoveg, string elvartHash)
        {
            CreateHash hash = new CreateHash();
            var generaltHash = hash.MakeHash(HashType.MD5, szoveg);
            Assert.AreEqual(elvartHash, generaltHash);
        }


    }
}