class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random number = new();
        int random = number.Next(0,AttackList.Count);
        Console.WriteLine($"{Name} performed the attack {AttackList[random].Name} for {AttackList[random].DamageAmount} damage");
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack){
        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} and reducing {Target.Name}'s health to {Target.Health}!!");
    }
}