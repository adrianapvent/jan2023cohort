class Projects : Developer {
    public string ProjName;

    public Projects(string theProjName, string theName): base(theName) {
        ProjName = theProjName;
    }
    public void PrintProjInfo() {
        Console.WriteLine($"{Name} is creating {ProjName}");
    }
}