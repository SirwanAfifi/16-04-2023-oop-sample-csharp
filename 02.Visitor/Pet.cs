namespace Visitor
{
    public class Pet
    {
        public string? Owner { get; set; }
        public int NumberofVisits { get; set; }
        public double CostPerVisit { get; set; }
        public DateTime JoinedPractice { get; set; }

        public virtual string Execute(IOperation operation)
        {
            return operation.Apply(this);
        }
    }
}