public abstract class Pet
{
    public string Owner { get; set; }

    public int NumberofVisits;
    public double CostPerVisit;
    public DateTime JoinedPractice;

    public string PetType { get { return GetType().Name; } }

    public virtual string Format() 
    {
        return $"{Owner},{JoinedPractice},{NumberofVisits},{CostPerVisit}";
    }
}