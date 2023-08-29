class Ranged : Enemy
{
    public int Distance;
    public bool CanAttack;

    public Ranged(string name) : base(name)
    {
        Name = name;
        Distance = 5;
        CanAttack = false;
        AttackList = new List<Attack>()
        {
            new Attack("Arrow Shot", 20),
            new Attack("Knife Throw", 15)
        };
    }
    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"{Name} dashes 20 meters away.");
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance < 10)
        {
            Console.WriteLine($"{Name} is too close to {Target.Name} to attack!");
        }
        else
        {
            Target.Health -= ChosenAttack.DamageAmount;
            Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} and reducing {Target.Name}'s health to {Target.Health}!!");
        }

    }

}