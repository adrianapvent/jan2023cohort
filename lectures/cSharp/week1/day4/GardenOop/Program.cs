// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Garden HBG = new Garden("Honey Bees Garden");
HBG.PrintGardenName();

Plant Thyme = new Plant("Thyme", "Herb");
Thyme.PrintPlantInfo();
Plant Strawberry = new Plant("Strawberries", "Fruit");

HBG.AllPlants.Add(Thyme);
HBG.ShowPlants();
HBG.AllPlants.Add(Strawberry);
HBG.ShowPlants();

Garden JHG = new Garden("Juli's Herb Garden");
JHG.AllPlants.Add(Thyme);
JHG.ShowPlants();