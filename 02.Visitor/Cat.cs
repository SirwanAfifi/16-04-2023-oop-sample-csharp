namespace Visitor
{
    public class Cat : Pet
    {
        public int NumberOfLives { get; set; }

        public override string Execute(IOperation operation)
        {
            return operation.Apply(this);
        }
    }
}