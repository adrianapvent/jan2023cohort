public class Owner {
    public string Name;
    public List<Pet> Pets;

    public Owner(string theName) {
        Name = theName;
        Pets = new List<Pet>();
    }

    public void PrintOwner() {
        Console.WriteLine($"{Name}");
    }
    public void PrintOwnerPets() {
        Console.WriteLine($"{Name} has the following pet(s)");
        foreach(var pet in Pets) {
            Console.WriteLine($"{pet.PetAge} year old {pet.PetName}");
        }
    }
}