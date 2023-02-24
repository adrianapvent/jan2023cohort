public class Pet {
    public string PetName;
    public int PetAge;
    public string PetColor;

    public Pet(string theName, int theAge, string theColor) {
        PetName = theName;
        PetAge = theAge;
        PetColor = theColor;
    }

    public void PrintPet() {
        Console.WriteLine($"{PetName} is {PetAge} years old and {PetColor}");
    }

}