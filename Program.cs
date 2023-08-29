// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Attack Fireball = new("Fireball", 25);
Attack CompassAir = new("Compass Needle: Air Type", 50);
Attack CompassAnn = new("Compass Needle: Annihilation Type", 75);

Enemy BadGuy = new("Akaza");

BadGuy.AttackList.Add(Fireball);
BadGuy.AttackList.Add(CompassAir);
BadGuy.AttackList.Add(CompassAnn);

BadGuy.RandomAttack();