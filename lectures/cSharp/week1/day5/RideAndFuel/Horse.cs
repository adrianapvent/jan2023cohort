class Horse : Vehicle, INeedFuel {

    public string FuelType {get; set;}
    public int FuelTotal {get; set;}
    public Horse(string theName, string theColor, string theType) :base(theName, 1, theColor, false) {
        FuelTotal = 10;
        FuelType = theType;
    }
    public override void ShowInfo() {
        base.ShowInfo();
        Console.WriteLine($"Fuel Type: {FuelType}, Total Current Fuel: {FuelTotal} Bales");
    }
    public void GiveFuel(int Amount) {
        this.FuelTotal += Amount;
        Console.WriteLine($"You just Fueled the {this.Name} with {FuelType} increasing the total fuel to {FuelTotal} Bales");
    }
}