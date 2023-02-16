class Garden {
    public string GardenName;
    public int MaxPlants;
    public List<Plant> AllPlants;

// Above is stating the attributes that our Garden class has and declaring the data type. The list is talking to the Plant class and because we can use the class name as the "data type" that is what we put in the <>

    public Garden(string theGarden) {
        GardenName = theGarden;
        MaxPlants = 20;
        AllPlants = new List<Plant>();
    }
// Above is our Constructor where we define what is required on Instance creation vs already predefined.  Because above is public any other class/file can access information 


// Below are our Methods.  Things we can do with the class
    public void PrintGardenName() {
        Console.WriteLine($"The new Garden is {GardenName}");
    }
    public void ShowPlants() {
        foreach(var plant in AllPlants) {
            Console.WriteLine($"{plant.PlantName} is in {GardenName}");
        }
    }
}