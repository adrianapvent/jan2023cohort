class Wine : Drink {

    public string Region;
    public int Year;

    public Wine(string theName, string theColor, double theTemp, bool theCarb, int theCals, string theRegion, int theYear) : base (theName, theColor, theTemp, theCarb, theCals) {
        Region = theRegion;
        Year = theYear;
    }

    public override void ShowDrink() {
        base.ShowDrink();
        Console.WriteLine($"The Region: {Region}");
        Console.WriteLine($"Year Made: {Year}");
        Console.WriteLine("-------------");
    }
}