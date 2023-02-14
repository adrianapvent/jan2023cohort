// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Arrays Lists Dictionaries
// Arrays have set length and are immutable in length but we can update values
// Lists are mutable
// Dictionaries are key/values

// ARRAYS
// type [] name = new type[length];
// Can not be redefined (like a let) however can be updated with new values

// Create our empty array - our array will contain strings it's called tvShows and has a length of 5
string[] tvShows01 = new string[5];
Console.WriteLine($"Our Array index 0 = {tvShows01[0]}");
tvShows01[0] = "Arcane"; // updates desired index with given value
Console.WriteLine($"Our Array now at index 0 = {tvShows01[0]}");
string[] tvShows = {"Flinstones", "Arcane", "Jetsons", "Scooby-Do", "Loony Toons"}; // Creating with a values already
Console.WriteLine(tvShows);

for(int i = 0; i < tvShows.Length; i++) {
    Console.WriteLine(tvShows[i]);
}

// LISTS
// List<type> name = new List<type>();
List<string> tvShowList = new List<string>();
// Console.WriteLine($"Our list {tvShowList}");
// Console.WriteLine($"Our list index 0 {tvShowList[0]}");
tvShowList.Add("Flinstones");
Console.WriteLine($"Our list{tvShowList}");
Console.WriteLine($"Our list index 0 {tvShowList[0]}");
tvShowList.Add("Arcane");
tvShowList.Add("Jetsons");
tvShowList.Add("Scooby-Do");
tvShowList.Add("Loony Toons");
for(int i = 0; i < tvShowList.Count; i++) {
    Console.WriteLine(tvShowList[i]);
}
foreach(string singleShow in tvShowList) {
    Console.WriteLine($"Foreach show in list {singleShow}");
}

// DICTIONARY
// a place to look up the definition of a word  key / value 
// Dictionary<type, type> name = new Dictionary<type, type>();
Dictionary<string, string> sundae = new Dictionary<string, string>();
sundae.Add("topping", "Hot Fudge");
sundae.Add("iceCreamFlavor", "Rocky Road");
Console.WriteLine(sundae["topping"]);
foreach(KeyValuePair<string, string> ingredient in sundae) {
    Console.WriteLine($"Our Sundae has a {ingredient.Key} of {ingredient.Value}");
}
foreach(var entry in sundae) {
    Console.WriteLine($"{entry.Key} and {entry.Value}");
}

Dictionary<string, int> grades = new Dictionary<string, int>();
grades.Add("Melissa", 90);
grades.Add("Julie", 100);
foreach(KeyValuePair<string, int> grade in grades) {
    Console.WriteLine($"{grade.Key} earned a {grade.Value}");
}
foreach(var grade in grades) {
    Console.WriteLine($"ALT WAY {grade.Key} earned a {grade.Value}");
}