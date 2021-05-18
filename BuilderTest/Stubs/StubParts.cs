namespace BuilderTest.Stubs
{
    using Builder;

    public class StubParts : Parts
    {
        public StubParts(string name): base(name)
        {
        }


        public override void Move(int meters)
        {
            throw new System.NotImplementedException();
        }
    }
}
