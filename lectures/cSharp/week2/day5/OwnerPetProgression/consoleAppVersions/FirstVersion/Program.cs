// Create Owners

Owner melissa = new Owner("Melissa");
Owner jane = new Owner("Jane");

// Create Pets

Pet copper = new Pet("Copper", 2, "Brown, White, and Black");
Pet tucker = new Pet("Mr. Tucker", 1, "Black with Brown");
Pet fluffy = new Pet("Fluffyopolus", 3, "White and Grey");
Pet max = new Pet("Maxamillion", 5, "White");


// Print Owners and Pets
melissa.PrintOwner();
jane.PrintOwner();

copper.PrintPet();
tucker.PrintPet();
fluffy.PrintPet();
max.PrintPet();

// Add pets to Owner lists
melissa.Pets.Add(copper);
melissa.Pets.Add(tucker);

jane.Pets.Add(fluffy);
jane.Pets.Add(max);


// print owner and their pets
melissa.PrintOwnerPets();

jane.PrintOwnerPets();