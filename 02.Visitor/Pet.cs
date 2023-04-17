using System.ComponentModel;

namespace Visitor
{
    public class Pet
    {
        [DisplayName("Owner")]
        public string? Owner { get; set; }
        [DisplayName("Number of Visits")]
        public int NumberofVisits { get; set; }
        [DisplayName("Cost Per Visit")]
        public double CostPerVisit { get; set; }
        [DisplayName("Joined Practice")]
        public DateTime JoinedPractice { get; set; }

        public virtual string Execute(IOperation operation)
        {
            return operation.Apply(this);
        }
    }
}