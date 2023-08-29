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
}