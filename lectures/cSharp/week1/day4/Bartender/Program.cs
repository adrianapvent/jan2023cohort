// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Coffee Moca = new Coffee("Moca", "Brown", 102.1, false, 200, "Medium", "Columbian");
Coffee Large = new Coffee("Large Black", "Black", 102.1, false, 200, "Dark", "Columbian");
Coffee Regular = new Coffee("Regular", "Cream", 102.1, false, 200, "Light", "Columbian");

Wine Zinfendell = new Wine("White Zinefendell", "White", 40, false, 200, "Cali", 1999);
Wine Red = new Wine("Pink", "White", 40, true, 200, "France", 1999);

Soda CodeRed = new Soda("Code Red MT Dew", "Red", 40, 300, false);
Soda Pepsi = new Soda("Pepsi", "Dark Brown", 40, 250, true);

List<Drink> AllBeverages = new List<Drink>();
AllBeverages.Add(Moca);
AllBeverages.Add(Large);
AllBeverages.Add(Regular);
AllBeverages.Add(Zinfendell);
AllBeverages.Add(Red);
AllBeverages.Add(CodeRed);
AllBeverages.Add(Pepsi);

foreach(Drink bev in AllBeverages) {
    bev.ShowDrink();
}