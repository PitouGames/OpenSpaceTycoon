using NUnit.Framework;

namespace OSTData.tst {

    [TestFixture]
    public class GameUnitTest {

        [SetUp]
        public void Init() {
        }

        [Test, Description("Creation")]
        public void GameConstruction1() {
            Game g = new Game();

            Assert.AreNotEqual(null, g.Universe);
        }
    }
}