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
}