class Ranged: Enemy 
{
    public int Distance;

    public Ranged (string name) : base(name)
    {
        AttackList = new List<Attack>() {

        new Attack ("Arrow", 20),
        new Attack ("Knife", 15),
        };

        Distance = 5;
    }

    public void Dash(){
    Distance = 20;
    Console.WriteLine($"{Distance}");
    }

    //  public override void ShowInfo()
    // {
    //     Console.WriteLine($"{Distance");
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance >= 10)
        {
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
            Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }else 
        {
            Console.WriteLine($"unable to perform attack.");
        }
    }
}