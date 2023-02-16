// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Three Basic Arrays
// Create an integer array with the values 0 through 9 inside.
int[] numArray = new int[10];
int[] numArray2 = {0,1,2,3,4,5,6,7,8,9,10};
// Console.WriteLine(numArray2[8]);
for (int i = 0; i < numArray2.Length; i++)
{
    // Console.WriteLine($"these are the numbers {numArray2[i]}");
}
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara"};
// Console.WriteLine(names[2]);
for (int i =0; i < names.Length; i++)
{
    // Console.WriteLine($"My name is {names[i]}");

}
foreach (string name in names)
{
    // Console.WriteLine($"No, only my name is {name}");
}
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] arr = new bool[11];
// Console.WriteLine(arr);
    arr[0] = true;
    arr[1] = false;
    arr[2] = true;
    arr[3] = false;
    arr[4] = true;
    arr[5] = false;
    arr[6] = true;
    arr[7] = false;
    arr[8] = true;
    arr[9] = false;
    arr[10] = true;
// Console.WriteLine("Values...");
foreach (bool response in arr)
{
    // Console.WriteLine(response);
}



// List of Flavors
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
// List<string> flavors = new List<string>();

// flavors.Add("chocolate");
// flavors.Add("vanilla");
// flavors.Add("strawberry");
// flavors.Add("rocky road");
// flavors.Add("lemon lime");

// Console.WriteLine($"The different flavors include:{flavors}");


// Output the length of the List after you added the flavors.
// List<string> flavors = new List<string>();

// flavors.Add("chocolate");
// flavors.Add("vanilla");
// flavors.Add("strawberry");
// flavors.Add("rocky road");
// flavors.Add("lemon lime");

// Console.WriteLine($"We have {flavors.Count} flavors");


// Output the third flavor in the List.
//  List<string> flavors = new List<string>();

// flavors.Add("chocolate");
// flavors.Add("vanilla");
// flavors.Add("strawberry");
// flavors.Add("rocky road");
// flavors.Add("lemon lime");

// Console.WriteLine($"Our most popular flavor is {flavors[2]}");


// Now remove the third flavor using its index location.
List<string> flavors = new List<string>();

flavors.Add("chocolate");
flavors.Add("vanilla");
flavors.Add("strawberry");
flavors.Add("rocky road");
flavors.Add("lemon lime");

flavors.Remove("strawberry");
// Console.WriteLine($"We have {flavors.Count} flavors");

// Output the length of the List again. It should now be one fewer.




// User Dictionary
// Create a dictionary that will store string keys and string values.
Dictionary<string,string> profile = new Dictionary<string,string>();

// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
profile.Add("Name", "Tim, Martin, Nikki, Sara");
profile.Add("Flavor", "chocolate, vanilla, strawberry, rocky road");
// profile.Add("Name", "Martin");
// profile.Add("Name", "Nikki");
// profile.Add("Name", "Sara");

// Console.WriteLine("Student Profile");

Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("Name - " + profile["Flavor"]);

Random rand = new Random();
for(int i = 0; i < names.Length; i++) 
{
    profile.Add(names[i], flavors[rand.Next(0,flavors.Count)]);
}

foreach(KeyValuePair<string,string> entry in profile)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}

// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
// Complete the Three Basic Arrays section. done!

// Complete the List of Flavors section. done!

// Complete the User Dictionary section.