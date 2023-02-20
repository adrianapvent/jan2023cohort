class Enemy {

    public string Name;

    public int Health;

    public List<Attack> AttackList;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack() {
        Random rand = new Random();
        int num = rand.Next(0, AttackList.Count);
        Attack attack = AttackList[num];
        Console.WriteLine($"Player used {attack.Name} and was damaged {attack.DamageAmount}");
    }

//     public void PerformAttack(Enemy Target, Attack ChosenAttack)
//     {
//         // Write some logic here to reduce the Targets health by your Attack's DamageAmount
//         Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
//     }
}