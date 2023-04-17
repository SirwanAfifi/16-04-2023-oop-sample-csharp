using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Visitor
{
    public class Report
    {
        private readonly List<Pet> _pets = new List<Pet>();
        public void AddPet(Pet pet)
        {
            _pets.Add(pet);
        }

        public void AddRange(List<Pet> pets)
        {
            _pets.AddRange(pets);
        }

        public void Execute(IOperation operation)
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Join(",", _pets.GetHeaders()));
            foreach (var pet in _pets)
            {
                sb.AppendLine(pet.Execute(operation));
            }
            File.WriteAllText("report.csv", sb.ToString());
            // File.WriteAllText("report.xml", sb.ToString());
        }
    }

    public static class PetListExtensionMethods
    {
        public static string GetHeaders(this List<Pet> pets)
        {
            var sb = new StringBuilder();
            var headers = pets
                .SelectMany(pet => pet.GetType().GetProperties())
                .Select(prop =>
                {
                    var displayNameAttr = prop.GetCustomAttribute<DisplayNameAttribute>();
                    return displayNameAttr != null ? displayNameAttr.DisplayName : prop.Name;
                })
                .Distinct()
                .ToArray();

            sb.AppendLine(string.Join(",", headers));
            return sb.ToString();
        }
    }
}