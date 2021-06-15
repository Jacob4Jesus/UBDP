using NUnit.Framework;

namespace UBDPLib_Test
{
    public class Nulltests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Pass()
        {
            Assert.Pass();
        }

        //[Test]
        public void Fail ()
        {
            Assert.Fail();
        }

    }
}