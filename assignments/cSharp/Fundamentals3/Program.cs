// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("------------");

// 1. Iterate and print values
static void PrintList(List<string> MyList)
// #1.
// {
//     foreach (var name in MyList)
//     {
//         Console.WriteLine(name);
//     }
// }
// #2. 
{
    for (int i = 0; i < MyList.Count; i++)
    {
        Console.WriteLine(MyList[i]);
    }
    Console.WriteLine("------------");
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

// 2. Print Sum
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach(var num in IntList) {
        sum += num;
        Console.WriteLine(sum);  
    }
    Console.WriteLine("------------");

}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);

// 3. Find Max
static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach(var num in IntList) {
        if(num > max) {
            max = num;
        } else {
            continue;
        }
    }
    Console.WriteLine(max);
    return max;
}

List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
FindMax(TestIntList2);
Console.WriteLine("------------");


// 4. Square the Values
static List<int> SquareValues(List<int> SquareList)
{
    List<int> Squared = new List<int>();
    foreach(int num in SquareList) {
        Squared.Add(num * num);
    }
    return Squared;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

foreach (int num in SquareValues(TestIntList3))
{
    Console.WriteLine(num + " ");
}
// // 5. Replace Negative Numbers with 0
// static int[] NonNegatives(int[] IntArray)
// {
//     // Your code here
// }
// int[] TestIntArray = new int[] {-1,2,3,-4,5};
// // You should get back [0,2,3,0,5], think about how you will show that this worked
// NonNegatives(TestIntArray);


// // 6. Print Dictionary
// static void PrintDictionary(Dictionary<string,string> MyDictionary)
// {
//     // Your code here
// }
// Dictionary<string,string> TestDict = new Dictionary<string,string>();
// TestDict.Add("HeroName", "Iron Man");
// TestDict.Add("RealName", "Tony Stark");
// TestDict.Add("Powers", "Money and intelligence");
// PrintDictionary(TestDict);

// // 7. Find Key
// static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
// {
//     // Your code here
// }
// // Use the TestDict from the earlier example or make your own
// // This should print true
// Console.WriteLine(FindKey(TestDict, "RealName"));
// // This should print false
// Console.WriteLine(FindKey(TestDict, "Name"));

// // 8. Generate a Dictionary
// // Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// // {
// //	"Julie": 6,
// //	"Harold": 12,
// //	"James": 7,
// //	"Monica": 10
// // } 
// static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
// {
//     // Your code here
// }
// // We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// // Your test code here


