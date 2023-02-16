class Plant {
    public string PlantName;
    public string PlantCategory;

    public Plant(string thePlant, string theCategory) {
        PlantName = thePlant;
        PlantCategory = theCategory;
    }

    public void PrintPlantInfo() {
        Console.WriteLine($"The new plant is {PlantName} and it is a {PlantCategory}");
    }
}