var pets = new List<Visitor.Pet> {
    new Visitor.Dog { Owner = "John", NumberofVisits = 1, CostPerVisit = 100, JoinedPractice = new DateTime(2018, 1, 1) },
    new Visitor.Cat { Owner = "John", NumberofVisits = 1, CostPerVisit = 100, JoinedPractice = new DateTime(2018, 1, 1), NumberOfLives = 9 },
    new Visitor.Dog { Owner = "John", NumberofVisits = 1, CostPerVisit = 100, JoinedPractice = new DateTime(2018, 1, 1) },
    new Visitor.Cat { Owner = "John", NumberofVisits = 1, CostPerVisit = 100, JoinedPractice = new DateTime(2020, 1, 1), NumberOfLives = 9 },
    new Visitor.Horse { Owner = "John", NumberofVisits = 1, CostPerVisit = 100, JoinedPractice = new DateTime(2018, 1, 1), Age = 1, Breed = "Arabian", Color = "Black", Price = 1000 },
    new Visitor.Horse { Owner = "John", NumberofVisits = 1, CostPerVisit = 100, JoinedPractice = new DateTime(2018, 1, 1), Age = 1, Breed = "Arabian", Color = "Black", Price = 1000 },
};
var report = new Visitor.Report();
report.AddRange(pets);
report.Execute(new Visitor.CsvOperation());
// report.Execute(new Visitor.XmlOperation());