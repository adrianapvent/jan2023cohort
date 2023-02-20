class Card {

    public string WholeCard;
    public int CardVal;

    public string CardSuit;

    public Card(string theCard, int theVal, string theSuit) {
        WholeCard = theCard;
        CardVal = theVal;
        CardSuit = theSuit;
    }
    public void PrintCard() {
        Console.WriteLine($"the {WholeCard} is: {CardVal} of {CardSuit}");
    }
}