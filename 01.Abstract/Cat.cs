public class Cat : Pet
{
    public int NumberOfLives;

    public override string Format()
    {
        return $"{PetType},{Owner},{JoinedPractice},{NumberofVisits},{NumberOfLives}";
    }
}