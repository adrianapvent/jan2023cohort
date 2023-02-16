class Teacher : Human {
    public string FavClass;

    public Teacher(string theFirst, string theLast, string theClass) : base(theFirst, theLast) {
        // What is after the : base is what is being shared from the human class
        FavClass = theClass;
    }
    public string PrintTeacher() {
        Console.WriteLine($"{FirstName} is a Student and likes {FavClass}");
        return FirstName + " and loves " + FavClass;
    }
}

// This Student class is a child of the Human class and thus can use the Human class methods