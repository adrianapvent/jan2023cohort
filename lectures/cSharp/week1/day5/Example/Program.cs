// Create a desk class where our squishies can go to live the desk has a name and a default hight and a list that will/can contain the squishies living there 

//Create a class called squishi to create a squishi instance we have to give it a name and by default it will have a stuffing value of true 


Desk mine = new Desk("Melissa's Desk");
Desk Sierra = new Desk("Sierra's Desk");


Squishi fluffy = new Squishi("Fluffy");
Squishi yankeeBoy = new Squishi("Yankee Boy");

fluffy.PrintInfo();
yankeeBoy.PrintInfo();

yankeeBoy.Hug(fluffy);

mine.AddSquishi(fluffy);

fluffy.Fell(mine);