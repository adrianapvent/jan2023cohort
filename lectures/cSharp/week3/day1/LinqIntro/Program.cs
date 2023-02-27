// Add this after doing the any function
void PrintEach(IEnumerable<dynamic> items, string msg = "") {
    Console.WriteLine("\n" + msg);
    foreach(var item in items) {
        Console.WriteLine(item.print());
    }
}


List<int> theNumbers = new List<int>() {
    2,5,7,90,10,3,6,7,20,4,60
};

List<int> numLessTwenty = theNumbers.Where(num => num < 20).ToList();

Console.WriteLine(string.Join(", ", numLessTwenty));
Console.WriteLine("----------------------------------------");
Console.WriteLine(string.Join(" ", numLessTwenty));
Console.WriteLine("----------------------------------------");


List<string> names = new List<string>() {
    "Melissa", "Juli", "Brianna", "Dana", "Muriel", "Adriana"
};
Console.WriteLine(string.Join(", ", names));
Console.WriteLine("----------------------------------------");

int minNameLength = names.Min(name => name.Length);
Console.WriteLine(minNameLength);
Console.WriteLine("----------------------------------------");

int maxNameLength = names.Max(name => name.Length);
Console.WriteLine(maxNameLength);
Console.WriteLine("----------------------------------------");


List<Trainer> trainers = new List<Trainer> {
    new Trainer(1, "Jane", "Doe", "jane@doe.com",2),
    new Trainer(2, "Bob", "Ross", "bob@ross.com", 5),
    new Trainer(3, "John", "Smith", "john@smith.com", 4),
    new Trainer(4, "John", "Doe", "john@doe.com", 2),
    new Trainer(5, "Cesar", "Milan", "cesar@milan.com", 10),
};
List<Dog> dogs = new List<Dog> {
    new Dog(1, "Copper Tone", "Longenberger","Beagle", 2, "Melissa"),
    new Dog(2, "Mr. Tucker", "Longenberger", "Cane Corso Mix", 1, "Melissa"),
    new Dog(3, "Lincoln", "Sepulveda", "Yorkie", 4, "Jackie"),
    new Dog(4, "Bethoven", "Gross", "St Bernard", 8, "Mar'Kebta"),
    new Dog(5, "Clifford", "Pena", "Big Red", 20, "Adriana"),
    new Dog(6, "Snoopy", "Villatoro", "Beagle", 20, "Lizette"),
    new Dog(7, "Iowa", "Fossi", "Lab", 3, "Muriel"),
};
// Trainer oneTrainer = trainers.First(t => t.FirstName == "Janee");
// Trainer oneTrainer = trainers.First(t => t.FirstName == "Jane");

// Trainer oneTrainer = trainers.FirstOrDefault(t => t.FirstName == "Janee");
Trainer oneTrainer = trainers.FirstOrDefault(t => t.FirstName == "Jane");

if(oneTrainer != null) {
    Console.WriteLine(oneTrainer.print());
} else {
    Console.WriteLine("Trainer not found");
}

Console.WriteLine("----------------------------------------");
List<Trainer> filterTrainers = trainers.OrderBy(trainer => trainer.Experience).ToList();
PrintEach(filterTrainers);
Console.WriteLine("----------------------------------------");
