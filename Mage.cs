class Mage : Enemy
{
    Attack Fireball = new("Fireball", 20);
    Attack Lightning = new("Lightning Bolt",20);
    Attack Strike = new("Staff Strike", 10);

    public Mage(string name): base(name)
    {
        Name= name;
        Health = 80;
        AttackList = new List<Attack>() 
        {
            new Attack("Fireball", 20),
            new Attack("Lightning Bolt", 20),
            new Attack("Staff Strike", 10)
        };

    }

    public void Heal(Enemy Target)
    {
        Target.Health += 40;
        Console.WriteLine($"{Name} heals {Target.Name} for 40 health points. {Target.Name}'s HP is now {Target.Health}!");
    }
}