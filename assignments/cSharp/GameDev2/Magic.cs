class Magic: Enemy 
{
    public Magic (string name) : base(name)
    {
        Health = 80;
        AttackList = new List<Attack>() {

        new Attack ("Fireball", 25),
        new Attack ("Lightning Bolt", 20),
        new Attack ("Staff Strike", 10),
        };
    }

    public void Heal(Enemy target){
        target.Health += 40;
        Console.WriteLine($"{Name} heals {target.Name}, increasing {target.Name}'s health to {target.Health}!!");
    }
}