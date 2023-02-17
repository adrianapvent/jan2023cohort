// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Enemy LordV = new Enemy("LordV"); 

Attack Fireball = new Attack ("Fireball", 20);
Attack Punch = new Attack ("Punch", 10);
Attack Throw = new Attack ("Throw", 5);

LordV.AttackList.Add(Fireball);
LordV.AttackList.Add(Punch);
LordV.AttackList.Add(Throw);

LordV.RandomAttack();
LordV.RandomAttack();
LordV.RandomAttack();
LordV.RandomAttack();
Console.WriteLine(LordV.Health);