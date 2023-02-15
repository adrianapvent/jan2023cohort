// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// var a = 1 var b = 3 var c = a + b

// Version 1
// This is hard coding and not reusable
int a = 1;
int b = 3;
int c = a + b;
Console.WriteLine($"{a} + {b} = {c}");
string d = "Italian";
// FUNCTIONS
// static type functionName() {
// // must have a return statement
// // will also have set amount of space reserved due to the type declared
// }

// static void functionName() {
// // this does not require a return statement
// // like a void has no pre determined space allocation making this less optimal for usage
// }

// Version 2
// This is better for typical use as normally we will want to use the results someplace
static int adding(int x, int y) {
    int z = x + y;
    Console.WriteLine($"the result is {z}");
    return z;
}
adding(2,5);

// Version 3
// This is good for testing that the logic works but not if we need the results
static void math01(int x, int y) {
    int z = x + y;
    Console.WriteLine($"the New result is {z}");
}
math01(5,8);

// TYPE CASTING

// Implicit Casting
// Allows us to change the var type with out loss of information
int favNum = 24;
double newFavNum = favNum;

// char favLetter = 'm';
// string newFavLetter = favLetter;

// Explicit Casting
// There will be some loss of information such as loosing a decimal place
double altFavNum = 24.24;
Console.WriteLine($"altFavNum {altFavNum}");
int newAltFavNum = (int)altFavNum;
Console.WriteLine($"newAltFavNum {newAltFavNum}");

string myNum = "24";
int altMyNum = Int32.Parse(myNum);
Console.WriteLine($"myNum is {myNum} and altMyNum is {altMyNum}");


// Unboxing
// a way of finding out what data type something is by putting it in a object

// object theNum = myNum;
object theNum = altMyNum;

if (theNum is int) {
    Console.WriteLine("print me if integer");
}
if (theNum is string) {
    Console.WriteLine("print me if a string");
}

object myFavFood = d;

if (myFavFood is int) {
    Console.WriteLine("print me if integer");
}
if (myFavFood is string) {
    Console.WriteLine("print me if a string");
}

// Safe Explicit Casting
// returns null if fails however the data type must be able to have a value of null 

object food = "Pizza";
string itsAString = food as string;
Console.WriteLine($"{food} is a string and we can safely declare it so inside our itsAString {itsAString}");

// object aNum = 2424;
// int itsAInt = aNum as int;
// Console.WriteLine($" {aNum} is an integer but can we make sure it is one in itsAInt {itsAInt}");

static int answerCheck(int g, int a) {
    if (g == a) {
        Console.WriteLine("correct");
        return 1;
    }
    else if (g > a) {
        Console.WriteLine("too high");
        return 0;
    }
    else {
        Console.WriteLine("too low");
        return 0;
    }
}
// Console.WriteLine(answerCheck(2,3));
int check = answerCheck(2,2);
if( check == 1) {
    Console.WriteLine("yay you won");
}
else {
    Console.WriteLine("booo bad guesser");
}