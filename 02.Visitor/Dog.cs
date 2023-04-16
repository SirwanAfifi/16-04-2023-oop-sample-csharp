namespace Visitor
{
    public class Dog : Pet
    {
        public override string Execute(IOperation operation)
        {
            return operation.Apply(this);
        }
    }
}