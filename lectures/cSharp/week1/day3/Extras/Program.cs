// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] names = {"Tim", "Martin", "Nikki","Sara"};



// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> iceCreamFlavs = new List<string>();
iceCreamFlavs.Add("Chocolate");
iceCreamFlavs.Add("Rocky Road");
iceCreamFlavs.Add("Mint Chocolate Chip");
iceCreamFlavs.Add("Strawberry");
iceCreamFlavs.Add("Vanilla");
iceCreamFlavs.Add("Chocolate Chip Cookie Doe");


// Create a dictionary that will store string keys and string values.
Dictionary<string, string> combo = new Dictionary<string, string>();
// Add key/value pairs to the dictionary where:
Random rand = new Random();
// string tempKey = "temp";
string tempValue = "temp";


combo.Add(names[rand.Next(4)], iceCreamFlavs[rand.Next(6)]);
foreach(KeyValuePair <string, string> item in combo) {
    Console.WriteLine($"{item.Key} {item.Value}");
}
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.


// Random rand = new Random();
// NameandFlav.Add ("Tim", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Martin", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Nikki", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Sara", iceCreamFlav[rand.Next(6)]);


// Console.WriteLine(NameandFlav["Tim"]);