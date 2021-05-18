namespace BuilderTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Builder;
    using Moq;

    [TestClass]
    public class ElfTest
    {
        Elf target;
        Mock<IReact> react;

        [TestInitialize]
        public void Setup()
        {
            react = new Mock<IReact>();
            target = new Elf("TestName", react.Object);
        }

        [TestMethod]
        public void Move_ExceedMaxDistance_Jump()
        {
            target.Move(14);
            react.Verify(x => x.Jump(), Times.Once);
        }

        [TestMethod]
        public void Move_BelowMinDistance_Eat()
        {
            target.Move(0);
            react.Verify(x => x.Eat(), Times.Once);
        }

        [TestMethod]
        public void Move_NormalDistance_CreateBlackhole()
        {
            target.Move(8);
            react.Verify(x => x.CreateBlackhole(), Times.Once);
        }

    }
}
