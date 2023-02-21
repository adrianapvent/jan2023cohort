// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Enemy LordV = new Enemy("LordV"); 
Melee Zeena = new Melee("Zeena");
Ranged Bella = new Ranged ("Bella");
Magic Dumbledore = new Magic("Dumbledore");

Zeena.PerformAttack(Bella, Zeena.AttackList[1]);
Zeena.Rage(Dumbledore);
Bella.PerformAttack(Zeena, Bella.AttackList[0]);
Bella.Dash();
Bella.PerformAttack(Zeena, Bella.AttackList[0]);
Dumbledore.PerformAttack(Zeena, Dumbledore.AttackList[0]);
Dumbledore.Heal(Bella);
Dumbledore.Heal(Dumbledore);

// Attack Fireball = new Attack ("Fireball", 20);
// Attack Punch = new Attack ("Punch", 10);
// Attack Throw = new Attack ("Throw", 5);

// LordV.AttackList.Add(Fireball);
// LordV.AttackList.Add(Punch);
// LordV.AttackList.Add(Throw);

// LordV.RandomAttack();
// LordV.RandomAttack();
// LordV.RandomAttack();
// LordV.RandomAttack();

Console.WriteLine(LordV.Health);
Console.WriteLine(Zeena.Health);