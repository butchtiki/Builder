namespace BuilderTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Builder;

    [TestClass]
    public class HumanTest
    {
        Human target;

        [TestInitialize]
        public void Setup()
        {
            this.target = new Human("TestHuman");
        }

        [TestMethod]
        public void Move_DistanceExceedMax_MovedTooMuch()
        {
            this.target.Move(15);
            Assert.AreEqual(MovementStatus.TOOLONG, target.movementStatus);
        }

        [TestMethod]
        public void Move_DistanceShortOfMin_MovedTooShort()
        {
            this.target.Move(0);
            Assert.AreEqual(MovementStatus.TOOSHORT, target.movementStatus);
        }

        [TestMethod]
        public void Move_DistanceBetweenMinAndMax_Normal()
        {
            this.target.Move(8);
            Assert.AreEqual(MovementStatus.NORMAL, target.movementStatus);
        }


    }
}
