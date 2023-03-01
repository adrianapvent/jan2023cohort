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
// List<Eruption> namedChile = eruptions.Where(c => c.Location == "Chile").ToList();
// PrintEach(namedChile, "Eruption in Chile");

//2. Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
// var hawaiianEruptions = eruptions.FirstOrDefault(c => c.Location == "Hawaiian Is");
// // PrintEach(hawaiianEruptions, "Hawaiian eruptions.");
// if(hawaiianEruptions == null) {
//     Console.WriteLine("No Hawaiian Is Eruption found.");
// } else {
//     Console.WriteLine(hawaiianEruptions);
// }

//3. Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
// var newZealandEruptions = eruptions.Where(c => c.Location == "New Zealand").FirstOrDefault(y => y.Year > 1900);
// Console.WriteLine(newZealandEruptions);

//5. Find all eruptions where the volcano's elevation is over 2000m and print them.
// IEnumerable<Eruption> eruptionOver = eruptions.Where(o =>o.ElevationInMeters > 2000);
// PrintEach(eruptionOver);

//6. Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
// IEnumerable<Eruption> lEruptions = eruptions.Where(n => n.Volcano.StartsWith("L")).ToList();
// PrintEach(lEruptions, "eruptions starting with L");
// int lEruptionsNum = eruptions.Where(n => n.Volcano.StartsWith("L")).Count();
// Console.WriteLine(lEruptionsNum);


//7. Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
// int maxElevation = eruptions.Max(m => m.ElevationInMeters);
// Console.WriteLine(maxElevation);

// //8. Use the highest elevation variable to find a print the name of the Volcano with that elevation.
// string highestElevation = eruptions.FirstOrDefault(h => h.ElevationInMeters == maxElevation).Volcano;
// Console.WriteLine(highestElevation);

//9. Print all Volcano names alphabetically.
// IEnumerable<Eruption> alphabetically = eruptions.OrderBy(a => a.Volcano);
// PrintEach(alphabetically);

//10. Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
// IEnumerable<Eruption> before1000 = eruptions.Where(e => e.Year < 1000).OrderBy(a => a.Volcano);
// PrintEach(before1000);

//11. BONUS: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
