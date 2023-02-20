class Sandwich :IRandom {
    public List<string> Ingredients;
    public string Name;

    public Sandwich(string theName) {
        Name = theName;
        Ingredients = new List<string>();
        Ingredients.Add("bread");
        Ingredients.Add("bread");
    }
    public void AddTopping(string theTopping) {
        Ingredients.Insert(1, theTopping); // 1 = place new topping between slices of bread but each after previous topping added
    }
    public void PrintSand() {
        Console.WriteLine("Welcome to HoneyBee's Shop, here is your order:");
        string yourCreation = ""; // and empty var called yourCreation
        foreach(string topping in Ingredients) { // going through all the toppings in the ingredients List
            yourCreation += topping + ", "; // now make yourCreation = each topping adding each as we get to them and having a , after each one
            // Before adding new toppings with AddTopping this would print as bread, bread
            // AddTopping - ham
            // bread, ham, bread
        }
        Console.WriteLine(yourCreation);
    }
    public void Randomize() {
        for(int i = 1; i < Ingredients.Count-1; i++) {
            Random rand = new Random();
            int newToppingIndex = rand.Next(1,Ingredients.Count-1); // where will place the topping in temp
            
            
            // Console.WriteLine($"newToppingIdex (random) = {newToppingIndex} i = {i}, temp is Ingredients[i] = {Ingredients[i]}");
            // this.PrintSand();

            string temp = Ingredients[i]; //topping at current index of i 

            Ingredients[i] = Ingredients[newToppingIndex];


            // Console.WriteLine($"leftside = {Ingredients[i]} = right side new place {Ingredients[newToppingIndex]}");
            // this.PrintSand();


            Ingredients[newToppingIndex] = temp;


            // Console.WriteLine($"leftside = {Ingredients[newToppingIndex]} = rightside {temp}");
            // this.PrintSand();

        }
    }
}