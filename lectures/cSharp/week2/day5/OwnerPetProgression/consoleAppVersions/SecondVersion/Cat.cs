public class Cat : Pet, IMethod {
    public string Species;

    public Cat(string theName, int theAge, string theColor) : base(theName, theAge, theColor) {
        Species = "Cat";
    }

    public void Cries(){
        Console.WriteLine($"When {this.PetName} Meows when they are hungry");
    }
    public void PrintInfo() {
        Console.WriteLine($"{this.PetName} is a {this.Species} and loves to play.");
    }
}