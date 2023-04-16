namespace Visitor
{
    public class XmlOperation : IOperation
    {
        public string Apply(Pet pet)
        {
            return $"<pet><owner>{pet.Owner}</owner><visits>{pet.NumberofVisits}</visits><cost>{pet.CostPerVisit}</cost><joined>{pet.JoinedPractice}</joined></pet>";
        }

        public string Apply(Cat cat)
        {
            return $"<cat><owner>{cat.Owner}</owner><visits>{cat.NumberofVisits}</visits><cost>{cat.CostPerVisit}</cost><joined>{cat.JoinedPractice}</joined><lives>{cat.NumberOfLives}</lives></cat>";
        }

        public string Apply(Dog dog)
        {
            return $"<dog><owner>{dog.Owner}</owner><visits>{dog.NumberofVisits}</visits><cost>{dog.CostPerVisit}</cost><joined>{dog.JoinedPractice}</joined></dog>";
        }

        public string Apply(Horse horse)
        {
            return $"<horse><owner>{horse.Owner}</owner><visits>{horse.NumberofVisits}</visits><cost>{horse.CostPerVisit}</cost><joined>{horse.JoinedPractice}</joined><age>{horse.Age}</age><breed>{horse.Breed}</breed><color>{horse.Color}</color><price>{horse.Price}</price></horse>";
        }
    }
}