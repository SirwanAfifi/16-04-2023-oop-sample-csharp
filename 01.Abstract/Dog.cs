public class Dog : Pet
{
    public override string Format()
    {
        return $"{PetType},{Owner},{JoinedPractice},{NumberofVisits}";
    }
}