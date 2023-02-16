class Human {
    public string FirstName;
    public string LastName;

    public Human(string theFirst, string theLast) {
        FirstName = theFirst;
        LastName = theLast;
    }

    // Methods
    public string Introduction() {
        Console.WriteLine($"{FirstName} {LastName}");
        return FirstName + " " + LastName;
    }
}

// This class is just what both teachers and students will have in common.  We could create a bunch of humans but this is just so we don't have to keep retyping firstname and lastname over and over