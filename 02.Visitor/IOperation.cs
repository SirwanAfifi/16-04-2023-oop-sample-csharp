namespace Visitor
{
    public interface IOperation
    {
        string Apply(Pet pet);
        string Apply(Cat cat);
        string Apply(Dog dog);
        string Apply(Horse horse);
    }
}