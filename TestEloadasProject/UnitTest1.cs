namespace TestEloadasProject
{
    public class EloadasTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Kontruktor_NegativSorokSzama_ArgumentException()
        {
            int sorokSzama = -5;
            int helyekSzama = 10;

            Assert.Throws<ArgumentException>(() => new Eloadas(sorokSzama, helyekSzama));
        }
    }
}