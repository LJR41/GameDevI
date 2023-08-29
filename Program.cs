// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Fighter BadGuy = new("Akaza");
Ranged BadArcher = new("Dark Elf");
Mage BadMage = new("Avalache");

BadGuy.PerformAttack(BadArcher, BadGuy.AttackList[1] );
BadGuy.Rage(BadMage);
BadArcher.PerformAttack(BadGuy, BadArcher.AttackList[0]);
BadArcher.Dash();
BadArcher.PerformAttack(BadGuy, BadArcher.AttackList[0]);
BadMage.PerformAttack(BadGuy, BadMage.AttackList[0]);
BadMage.Heal(BadArcher);
BadMage.Heal(BadMage);
