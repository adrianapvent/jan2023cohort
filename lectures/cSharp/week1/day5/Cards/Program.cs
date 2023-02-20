// Card ourDeck = Card(Deck());
Sandwich hamNCheese = new Sandwich("Ham and Cheese");
Sandwich phili = new Sandwich("Philli Cheese Steak");

// hamNCheese.PrintSand();
hamNCheese.AddTopping("Ham");
hamNCheese.AddTopping("Cheese");
hamNCheese.AddTopping("onions");
hamNCheese.AddTopping("Mayo");
hamNCheese.PrintSand();
// Adding topping in specific order

// Person 2 doesn't care what order the toppings arein as long as it is in between the bread
phili.AddTopping("onions");
phili.AddTopping("peppers");
phili.AddTopping("chesse");
phili.AddTopping("steak");
phili.AddTopping("salt");
// phili.PrintSand();

phili.Randomize(); //using the interface to allow for orders to be different
phili.PrintSand();