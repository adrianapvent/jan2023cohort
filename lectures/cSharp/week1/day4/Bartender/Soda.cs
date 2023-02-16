class Soda : Drink {

    public bool Diet;

// in the () is what will be required. Since we are telling the class that ALL sodas are carbonated it is no longer a required field.
    public Soda(string theName, string theColor, double theTemp, int theCals, bool theDiet) : base (theName, theColor, theTemp, true, theCals) {
        Diet = theDiet;
    }
    public override void ShowDrink() {
    base.ShowDrink();
    Console.WriteLine($"Diet Y/N: {Diet}");
    Console.WriteLine("-------------");
    }
}