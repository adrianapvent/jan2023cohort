class Coffee : Drink {

    public string Roast; // dark medium light
    public string Beans;

    public Coffee(string theName, string theColor, double theTemp, bool theCarb, int theCals, string theRoast, string theBeans) : base (theName, theColor, theTemp, theCarb, theCals) {
        Roast = theRoast;
        Beans = theBeans;
    }

    public override void ShowDrink() {
    base.ShowDrink();
    Console.WriteLine($"The Roast: {Roast}");
    Console.WriteLine($"The Beans: {Beans}");
    Console.WriteLine("-------------");
    }
}