// public allows other classes to use the attributes/ methods like for 1:m relationships where private it the class only
class Developer {
    public string Name;
    private int Age;
    public int TimeOnJob;
    public string Role;

    public Developer(string theName, int theAge) {
        Name = theName;
        Age = theAge;
        TimeOnJob = 0;
        Role = "JR Dev";
    }

    public void PrintHired() {
        Console.WriteLine("A New Developer was hired");
    }
    public void PrintHiredDev() {
        Console.WriteLine($"{Name} was hired for the the {Role} role");
    }
    public void PrintDevInfo() {
        Console.WriteLine($"{Name} was hired for the {Role} role, time on job is {TimeOnJob} days and age is {Age} years old");
    }
}