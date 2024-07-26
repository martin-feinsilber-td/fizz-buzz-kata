namespace DefaultNamespace
{
    public class FizzBuzzTests
    {
        [Test]
        public void WhenInputIsNotDevisibleReturnNumber()
        {
            Assert.AreEqual(1, FizzBuzz.ConvertNumber(1));
        }
    }
}