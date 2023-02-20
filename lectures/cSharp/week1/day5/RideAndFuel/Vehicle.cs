abstract class Vehicle {
    public string Name;
    public int PassCount;
    public string Color;
    public bool Engine;
    public int Distance;

    public Vehicle(string theName, int thePass, string theColor, bool theEngine) {
        Name = theName;
        PassCount = thePass;
        Color = theColor;
        Engine = theEngine;
        Distance = 0;
    }

    public Vehicle(string theName, string theColor) {
        Name = theName;
        PassCount = 4;
        Color = theColor;
        Engine = true;
        Distance = 0;
    }


    // Methods start here
    public virtual void ShowInfo() {
        Console.WriteLine($"Name: {this.Name}, Passenger Count: {PassCount}, Color: {Color}, Has Engine: {Engine}, Distance Traveled: {Distance} miles");
    }
    public void Travel(int miles) {
        this.Distance += miles;
        Console.WriteLine($"The {Name} has just traveled {miles} miles, it's total distance traveled is now {this.Distance} miles");
    }

}