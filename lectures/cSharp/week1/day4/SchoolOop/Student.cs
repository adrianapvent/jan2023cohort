class Student : Human {
    public string FavCode;

    public Student(string theFirst, string theLast, string theCode) : base(theFirst, theLast) {
        // What is after the : base is what is being shared from the human class
        FavCode = theCode;
    }
    public string PrintStudent() {
        Console.WriteLine($"{FirstName} is a Student and likes {FavCode}");
        return FirstName + " is a student " + FavCode;
    }
}

// This Student class is a child of the Human class and thus can use the Human class methods