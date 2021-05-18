namespace BuilderTest
{
    using Builder;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PlayerBuilderTest
    {
        PlayerBuilder target;

        [TestInitialize]
        public void Setup()
        {
            target = new PlayerBuilder();
        }

        [TestMethod]
        public void CreateRealisticPlayer_InputIsNotNull_InputIsPlayerName()
        {
            var expected = "TestPlayer";
            var result = this.target.CreateFantasyPlayer(expected);

            Assert.AreEqual(expected, result.Name);  
        }

        [TestMethod]
        public void CreateRealisticPlayer_InputIsNull_PlayerNameIsEmptyString()
        {
            var expected = string.Empty;
            var result = this.target.CreateRealisticPlayer(null);

            Assert.AreEqual(expected, result.Name);
        }

        [TestMethod]
        public void CreateFanstasyPlayer_InputIsNotNull_InputIsPlayerName()
        {
            var expected = "TestPlayer";
            var result = this.target.CreateFantasyPlayer(expected);

            Assert.AreEqual(expected, result.Name);
        }

        [TestMethod]
        public void CreateFantasyPlayer_InputIsNull_PlayerNameIsEmptyString()
        {
            var expected = string.Empty;
            var result = this.target.CreateFantasyPlayer(null);

            Assert.AreEqual(expected, result.Name);
        }
    }
}
