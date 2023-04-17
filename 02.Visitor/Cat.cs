using System.ComponentModel;

namespace Visitor
{
    public class Cat : Pet
    {
        [DisplayName("Number of Lives")]
        public int NumberOfLives { get; set; }

        public override string Execute(IOperation operation)
        {
            return operation.Apply(this);
        }
    }
}