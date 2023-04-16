namespace Visitor
{
    public class Horse : Pet
    {
        public int Age { get; set; }
        public string? Breed { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public override string Execute(IOperation operation)
        {
            return operation.Apply(this);
        }
    }
}