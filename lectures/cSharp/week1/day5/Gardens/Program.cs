Garden Honeybee = new Garden("HoneyBee's Garden");
Garden Bronx = new Garden("The Botanical Garden");

Honeybee.GardenInfo();

Honeybee.ShowPlants();
Bronx.ShowPlants();

Honeybee.PlantOfTheDay();



Edible Basil = new Edible("Basil", "Annual Herb", "Weekly");
Edible Rosemary = new Edible("Rosemary", "Perennial Herb", "Monthly");
Edible Chive = new Edible("Chives", "Perennial Herb", "Weekly");
Edible Pumpkin = new Edible("Pumpkin", "Annual Vegetable", "Once");

GroundCover FourOClocks = new GroundCover("4 O'clocks");
GroundCover Hasta = new GroundCover("Hasta");
GroundCover Ivy = new GroundCover("English Ivy");

Decorative JapanMaple = new Decorative("Japanese Maple");
Decorative DogWood = new Decorative("Flowering Dogwood");
Decorative Rose = new Decorative("Rose Bush");
Decorative RoseOfSharon = new Decorative("Rose of Sharon");

Basil.AddPlant(Basil, Honeybee);
Rosemary.AddPlant(Rosemary, Honeybee);

Hasta.AddPlant(Hasta, Honeybee);

Hasta.SlowGrow();
Hasta.AddPlant(Hasta, Honeybee);