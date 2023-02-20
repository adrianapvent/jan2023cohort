// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Every Developer we hire will now have to provide to us their name and age.  We will start them all off with time on job with us at 0 and the role of JR Dev.  These values can change later but every new developer will start with these.
class Developer {
    string Name; // This is an attribute that we will want every Developer to have
    int Age;
    int TimeOnJob;
    string Role;

    Developer(string theName, int theAge) {
        Name = theName; //theName is the parameter being passed into the function on line 7 (what we will use to create a developer)
        Age = theAge;
        TimeOnJob = 0;
        Role = "JR Dev";
    }
}


// melissa = new Developer("Melissa", 44)


// Developer Melissa = new Developer("Melissa", 44);


// Developer = the data type (as our class has multiple data types we use the class name as it's type)
// Melissa = the variable we are using to call this specific developer we just hired
// new Developer("Melissa", 44) = is how we are entering Melissa into our system as a newly hired developer if printed right now the attributes for melissa would be name=Melissa age=44 timeonjob=0 and role=jr dev