// Create a desk class where our squishies can go to live the desk has a name and a default hight and a list that will contain the squishies living there 
// we create an empty list because person 1 has a desk and squishies and person 2 has one as well they can have the same type of squishies but not always

class Desk {
    public string Name;
    public int Height;
    public List<Squishi> DeskSquishies;

    public Desk(string theName) {
        Name = theName;
        Height = 1;
        DeskSquishies = new List<Squishi>();
    }
    public void AddSquishi(Squishi foundHome) {
        DeskSquishies.Add(foundHome);
        Console.WriteLine($"The amazing {foundHome.Name} is now living on {this.Name}");
    }
}