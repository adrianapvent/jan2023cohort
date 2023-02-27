// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");

// Execute Assignment Tasks here!
// 1. Use LINQ to find the first eruption that is in Chile and print the result.
List<Eruption> namedChile = eruptions.Where(c => c.Location == "Chile").ToList();
PrintEach(namedChile, "Eruption in Chile");

//2. Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
var hawaiianEruptions = eruptions.FirstOrDefault(c => c.Location == "Hawaiian Is");
// PrintEach(hawaiianEruptions, "Hawaiian eruptions.");
if(hawaiianEruptions == null) {
    Console.WriteLine("No Hawaiian Is Eruption found.");
} else {
    Console.WriteLine(hawaiianEruptions);
}

//3. Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
var NewZealandEruptions = eruptions.Where(c => c.Locations == "New Zealand").FirstOrDefault(y => y.Year > 1900);
Console.WriteLine(NewZealandEruptions);

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
