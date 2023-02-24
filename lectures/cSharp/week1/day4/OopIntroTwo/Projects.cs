class Projects : Developer {
    public string ProjName;

    public Projects(string theProjName, string theName, int theAge): base(theName, theAge) {
        ProjName = theProjName;
    }
    public void PrintProjInfo() {
        Console.WriteLine($"{Name} is creating {ProjName}");
    }
}