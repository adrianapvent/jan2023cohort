class Projects : Developer {
    public string ProjName;

    public Projects(string theProjName, string theName): base(Name) {
        ProjName = theProjName;
    }
    public void PrintProjInfo() {
        Console.WriteLine($"{Name} is creating {ProjName}");
    }
}