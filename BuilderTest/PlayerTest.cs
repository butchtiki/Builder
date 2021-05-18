namespace BuilderTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Builder;
    using BuilderTest.Stubs;
    using Moq;

    [TestClass]
    public class PlayerTest
    {
        Player target;
        StubParts part;

        [TestInitialize]
        public void Setup()
        {
            this.part = new StubParts("TestName");
            this.target = new Player("Butchtiki");
        }

        [TestMethod]
        public void AddPart_ValidInput_ReturnsTrue()
        {
            var name = "PartName";
            var result = this.target.AddPart(name, this.part);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddPart_InvalidInput_ReturnsFalse()
        {
            var result = this.target.AddPart(null, this.part);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Move_MethodIsRan_NoException()
        {
            this.target.Move(15);
        }


    }
}
