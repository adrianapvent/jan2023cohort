class Deck{
    public List<Card> cards;

    public Deck() {
        cards = new List<Card>();
        popDeck();
    }
    public void popDeck() {
        string[] suits = {"Spades", "Diamonds", "Hearts", "Clubs"};

        foreach(string suit in suits) { // go through the array of suits
            for(int i = 1; i < 14; i++) { // go through the avail number values
                string theValAsString;

                if(i > 1 && i < 11) {
                    theValAsString = i.ToString(); // changing the 2-10 ints to strings
                }
                else if(i == 1) {
                    theValAsString = "Ace";
                }
                else if(i == 11) {
                    theValAsString = "Jack";
                }
                else if(i == 12) {
                    theValAsString = "Queen";
                }
                else {
                    theValAsString = "King";
                }

                cards.Add(new Card(theValAsString, i, suit));
                // card list add (new card with a string value of i, a int value of i, and a suit of suit)
                // 1st loop will return ("Ace", 1, "Spades")
                // 2nd loop will return ("2", 2, "Spades")
            }
        }
    }
    // public void Randomize() {
    //     Shuffle();
    // }
    
}