// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("------------------------------");
Console.WriteLine("Welcome to class!");

Console.WriteLine("------------------------------");
int count = 1;
while(count < 11) {
    Console.WriteLine($"{count}");
    count++;
}
Console.WriteLine("------------------------------");
List<string> animals = new List <string> ();
animals.Add("Zebra");
animals.Add("Lion");
animals.Add("Tiger");
animals.Add("Bear");
Console.WriteLine("------------------------------");

string[] foods = new string[4];
foods[0] = "Pizza";
foods[1] = "Wings";
foods[2] = "Sushi";
foods[3] = "Ramen";
Console.WriteLine("------------------------------");

Dictionary<string, int> namesList = new Dictionary<string, int>();
namesList.Add("Lizette", 23);
namesList.Add("Melissa", 44);
Console.WriteLine("------------------------------");

for(int i = 0; i < 4; i++){
    Console.WriteLine(animals[i]);
}

for(int i = 0; i < animals.Count; i++){
    Console.WriteLine(animals[i]);
}
Console.WriteLine("------------------------------");
foreach(string food in foods) {
    Console.WriteLine(food);
}
Console.WriteLine("------------------------------");
foreach(var entry in namesList) {
    Console.WriteLine($"{entry.Key} is {entry.Value} years old");
}
Console.WriteLine("------------------------------");

foreach(var entry in namesList){
    int results = entry.Value;
    // if(int.TryParse(results, out number)) { // didn't work as results was already a int and tryParse changes from string to int ("2" to 2)
    if(results is int){
        Console.WriteLine("This is a number");
    } else {
        Console.WriteLine("This is not a number");
    }
}
Console.WriteLine("------------------------------");

List<int> gradeList = new List<int>();
gradeList.Add(99);
gradeList.Add(80);
gradeList.Add(95);
Console.WriteLine("------------------------------");

static double average(List<int> list){
    int sum = 0;
    foreach(int grade in list) {
        sum += grade;
    }
    return (double)sum/list.Count; // The double here allows for the sum (declared as int and Count default of int to return as a double)
}
Console.WriteLine(average(gradeList));
Console.WriteLine("------------------------------");
// dictionary<string, int> namesList = new dictionary<string, int>();
Random random = new Random();
int rNum = random.Next(namesList.Count); // creating a var rKey making it = a random number no larger than the number of idexes in the dictionary
// string key = namesList.Keys.ElementAt(rKey); // pulling the 
KeyValuePair<string, int> aKey = namesList.ElementAt(rNum); // KeyValuePair is a predefined class.  This is where we are pulling the random entry from the dictionary and assigning aKey to it
Console.WriteLine("key: " + aKey.Key + ", value: " + aKey.Value);

Console.WriteLine("------------------------------");
// dictionary<string, int> namesList = new dictionary<string, int>();
// namesList.Add("Lizette", 23);
// namesList.Add("Melissa", 44);

foreach(var age in namesList) {
    Console.WriteLine("age: " + age.Value);
}

Console.WriteLine("------------------------------");
string name = "Melissa";
string altName = "Kaitlynn";
Console.WriteLine(String.Format("Hello, {0}, my name is {1}", name, altName));