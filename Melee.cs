class Fighter : Enemy
{

    public Fighter(string name) : base(name)
    {
        Name = name;
        Health = 120;
        AttackList = new List<Attack>() 
        { 
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
    }

    public void Rage(Enemy Target)
    {
        
        Random number = new();
        int random = number.Next(0, AttackList.Count);
        AttackList[random].DamageAmount += 10;
        Target.Health -= AttackList[random].DamageAmount;
        Console.WriteLine($"{Name} enters a rage and uses {AttackList[random].Name} on {Target.Name}, dealing {AttackList[random].DamageAmount} and reducing {Target.Name}'s health to {Target.Health}!!");
    
    }
    
}