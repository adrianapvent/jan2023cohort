// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> TestIntList = new List<int>() {2,7,12,9,3};
List<int> TestInt = new List<int>() {5,7,8,9,12,3,4};

static void SumOfNumbers(List<int> arr) // static void = function SumOfNumbers = function name (List<int> arr) = what we will need to provide the function when we call/activate it
{
    // Your code here
    int sum = 0;
    foreach(var a  in arr) { // use arr as that is the temp var we are using to make our function reusable
        sum += a;
        Console.WriteLine(sum);
    }
}

// You should get back 33 in this example
SumOfNumbers(TestIntList);  // Calling the function and passing in our desired information
SumOfNumbers(TestInt);


// Version 2 but bad because not DRY
static void SumOfNumbers02()
{
    List<int> TestIntList = new List<int>() {2,7,12,9,3};
    // Your code here
    int sum = 0;
    foreach(var a  in TestIntList) {
        sum += a;
        Console.WriteLine(sum);
    }
}

// You should get back 33 in this example
SumOfNumbers02();