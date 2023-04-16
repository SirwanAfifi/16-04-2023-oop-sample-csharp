namespace Visitor
{
    public class CsvOperation : IOperation
    {
        public string Apply(Pet pet)
        {
            return $"{pet.Owner},{pet.NumberofVisits},{pet.CostPerVisit},{pet.JoinedPractice}";
        }

        public string Apply(Cat cat)
        {
            return $"{cat.Owner},{cat.NumberofVisits},{cat.CostPerVisit},{cat.JoinedPractice},{cat.NumberOfLives}";
        }

        public string Apply(Dog dog)
        {
            return $"{dog.Owner},{dog.NumberofVisits},{dog.CostPerVisit},{dog.JoinedPractice}";
        }

        public string Apply(Horse horse)
        {
            return $"{horse.Owner},{horse.NumberofVisits},{horse.CostPerVisit},{horse.JoinedPractice},{horse.Age},{horse.Breed},{horse.Color},{horse.Price}";
        }
    }
}