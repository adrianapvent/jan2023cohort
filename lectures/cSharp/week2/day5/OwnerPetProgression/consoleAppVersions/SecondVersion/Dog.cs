public class Dog : Pet, IMethod {
    public string Species;
        public Dog(string theName, int theAge, string theColor) : base(theName, theAge, theColor) {
        Species = "Dog";
    }
    public void Barks(){
        Console.WriteLine($"When {this.PetName} loves to Bark when they are happy");
    }
    public void PrintInfo() {
        Console.WriteLine($"{this.PetName} is a {this.Species} and loves to play.");
    }
}