namespace BuilderTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Builder;

    [TestClass]
    public class UnicornTest
    {
        Unicorn target;

        [TestInitialize]
        public void Setup()
        {
            target = new Unicorn("TestName");
        }

        [TestMethod]
        public void Move_ValidInput_NoException()
        {
            target.Move(3);
        }
    }
}
