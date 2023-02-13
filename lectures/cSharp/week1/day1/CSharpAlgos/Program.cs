// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// string data = double quotes any length
string data01 = "I am a string";

// char data = single quote 1 letter only
char data02 = 'I';

// int data = whole number
int data03 = 24;

// long data = longer whole number
long data04 = 15000000L;

// float data = decimal
// float data05 = 24.24;
float data08 = 24.24F;

// double data = longer decimal
double data06 = 15000.00D;

// boolean data = true / false
bool data07 = true;

// print the numbers 1-5

// for loop version
for(int i = 1; i <=5; i++) {
    Console.WriteLine("for loop", i); // This will print but only the words in quotes not the value of i
    Console.WriteLine($"for loop: {i}");
}

// while loop version
int x = 1;
while(x <= 5) {
    Console.WriteLine("while loop " + x); // This also works if you don't like the $ {} method
    Console.WriteLine($"while loop: {x}");
    x++;
}

// check to see if data03 is larger than data08

if (data03 > data08) {
    Console.WriteLine($"{data03} is larger than {data08}");
} else {
    Console.WriteLine($"{data03} is the smaller number");
}

int temperature = 62;
string weather = "Cloudy";
// If the temperature is greater than or equal to 72 OR the weather is sunny, we run the first condition
if(temperature >= 72 || weather == "Sunny"){
    Console.WriteLine("It's a beautiful day to go outside!");
// Otherwise, if the temperature is greater than 64 AND it is not raining out, we run the second condition
} if(temperature > 64 && weather != "Rainy") {
	Console.WriteLine("I think it should be fine to go outside today with a jacket.");    
} if(temperature < 64 || weather != "Cloudy") {
    Console.WriteLine("Might be an ok day");
} if(temperature < 64 && weather == "Cloudy") {
    Console.WriteLine("Dark and gloomy today");
} else {
    Console.WriteLine("Maybe I'll stay inside today.");
}

// if if else = any of the if statements that are true will be run
// if else if else = the 1st true statement it comes across will run and thats it


Random rand = new Random();
// y will go from 1-10 inclusive and increase by 1 each time
for(int y = 1; y <= 10; y++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    // allow starting at 2 stop at 8 (8 is not inclusive it is exclusive)
    Console.WriteLine(rand.Next(2,8));
    // Console.WriteLine(rand.Next(2,15));
}
// if we wanted to save these numbers we could add to a list

for(int z = 1; z <= 10; z++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.Next(2,8));
}

// JS Tuple () = C# Array {}
// JS Array [] = C# List
// JS Object {} = C# Dictionary