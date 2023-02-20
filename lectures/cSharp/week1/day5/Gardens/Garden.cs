class Garden {
    public string GardenName;
    public int GardenCapacity;
    public List<Plant> AllPlants;

    public Garden(string theGarden) {
        GardenName = theGarden;
        GardenCapacity = 10;
        AllPlants = new List<Plant>();
    }

    public void GardenAdded() {
        Console.WriteLine("A new Garden has been added");
    }
    public void GardenInfo() {
        Console.WriteLine($"{GardenName} has a Capacity of {GardenCapacity} plants");
    }
    public void ShowPlants() {
        foreach(var plant in AllPlants) {
            Console.WriteLine($"{plant.PlantName} is in {GardenName}, we can still fit {GardenCapacity} more plants");

        }
    }
    public void StolenPlant() {
        Random rand = new Random();
        int steel = rand.Next(AllPlants.Count); 
        Console.WriteLine($"{this.GardenName} had a break-in and all of then {AllPlants[steel].PlantName}'s were stolen");
    }

    public void PlantOfTheDay() {
        Random rand = new Random();
        int spotlight = rand.Next(AllPlants.Count);
        Console.WriteLine($"{GardenName} is proud to present {AllPlants[spotlight].PlantName}");
    }
}