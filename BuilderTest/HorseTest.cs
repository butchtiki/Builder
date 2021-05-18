namespace BuilderTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Builder;

    [TestClass]
    public class HorseTest
    {
        Horse target;

        [TestInitialize]
        public void Setup()
        {
            this.target = new Horse("Yeeha");
        }

        [TestMethod]
        public void Move_ExceedMaxDistance_Cry()
        {
            this.target.Move(15);
            Assert.IsTrue(target.moodStatus == Horse.MoodStatus.CRY);
        }

        [TestMethod]
        public void Move_BelowMinDistance_NoFeelings()
        {
            this.target.Move(0);
            Assert.IsTrue(target.moodStatus == Horse.MoodStatus.NOFEELINGS);
        }

        [TestMethod]
        public void Move_BetweenMinAndMax_Normal()
        {
            this.target.Move(8);
            Assert.IsTrue(target.moodStatus == Horse.MoodStatus.NORMAL);
        }
    }
}
