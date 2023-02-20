//Create a class called squishi to create a squishi instance we have to give it a name and by default it will have a stuffing value of true 

class Squishi {
    // These are the attributes that every squishi we ever make will HAVE to have

    public string Name;
    public bool Stuffing;

    // Constructor tells us the attributes we get to make up vs are already determined for us
    // in this constructor we know that we get to make up a name for our squishi but we are already told that it will have stuffing
    // inside the () is what we can make up 
    // if it is already told to us it will have it's value in the {} when it is called there
    // Everything that each squishi HAS to HAVE will have an entry in the {}

    public Squishi(string theName) {
        Name = theName;
        Stuffing = true;
    }

    // After the constructor comes our methods..... what can we make our squishies do or what can we do with them or something regarding them

    // we can print their info (do with them)
    public void PrintInfo() {
        Console.WriteLine($"Congratulations on your new Squishy named {Name}");
    }

    // we can make them hug each other (what we can make our squishies do)
    public void Hug(Squishi hugs) {
        Console.WriteLine($"{this.Name} is now hugging {hugs.Name}");
    }

    public void Fell(Desk whatDesk) {
        if(whatDesk.Height > 0) {
            this.Stuffing = false;
        }
        Console.WriteLine($"Oh no {this.Name} fell from {whatDesk.Name} it was {whatDesk.Height} feet from the ground! Does it still have it's stuffing? {this.Stuffing}");
    }
}