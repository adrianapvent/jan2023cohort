class Plant {
    public string PlantName;
    public string SunReqs;
    public int SpreadRate;
    public List<Garden> AllGardens;

    public Plant(string thePlant) {
        PlantName = thePlant;
        SunReqs = "Full";
        SpreadRate  = 2;
        AllGardens = new List<Garden>();

    }

    public void PrintPlantInfo() {
        Console.WriteLine($"The new plant is {PlantName}");
    }

// What plant are we going to move and where are going we going to put it
    public virtual void AddPlant(Plant APlant, Garden ChosenGarden) {
        ChosenGarden.GardenCapacity -= this.SpreadRate;
        Console.WriteLine($"{APlant.PlantName} was added to {ChosenGarden.GardenName} and used up {APlant.SpreadRate} spaces so now {ChosenGarden.GardenName} has {ChosenGarden.GardenCapacity} remaining spots");
    }
}