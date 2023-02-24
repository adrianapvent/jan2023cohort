// Create Owners

Owner melissa = new Owner("Melissa");
Owner jane = new Owner("Jane");


// Create Pets

Dog copper = new Dog("Copper", 2, "Brown, White, and Black");
Dog tucker = new Dog("Mr. Tucker", 1, "Black with Brown");
Cat fluffy = new Cat("Fluffyopolus", 3, "White and Grey");
Dog max = new Dog("Maxamillion", 5, "White");

// Print Owners and Pets
melissa.PrintOwner();
jane.PrintOwner();

copper.PrintPet();
tucker.PrintPet();
fluffy.PrintPet();
max.PrintPet();

// Other methods

copper.Barks();
tucker.Barks();
fluffy.Cries();
max.Barks();

copper.PrintInfo();
tucker.PrintInfo();
fluffy.PrintInfo();
max.PrintInfo();


// Add pets to Owner lists
melissa.Pets.Add(copper);
melissa.Pets.Add(tucker);

jane.Pets.Add(fluffy);
jane.Pets.Add(max);


// print owner and their pets
melissa.PrintOwnerPets();

jane.PrintOwnerPets();