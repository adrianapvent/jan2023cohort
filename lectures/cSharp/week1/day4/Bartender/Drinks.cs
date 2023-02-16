class Drink
{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;
    
    // We need a basic constructor that takes all these features in
    public Drink(string theName, string theColor, double theTemp, bool theCarb, int theCals)
    {
        Name = theName;
        Color = theColor;
        Temperature = theTemp;
        IsCarbonated = theCarb;
        Calories = theCals;
    }

    public virtual void ShowDrink() {
        Console.WriteLine("-------------");
        Console.WriteLine($"Drink Name: {Name}");
        Console.WriteLine($"Drink Color: {Color}");
        Console.WriteLine($"Drink Temp: {Temperature}");
        Console.WriteLine($"Drink Carbonated: {IsCarbonated}");
        Console.WriteLine($"Drink Calories: {Calories}");

    }
}

