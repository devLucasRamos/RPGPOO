using RPGPOO.Entities;

Hero arus = new Knight("Arus",23,"Knight");
Hero wizard = new Wizard("Jennica", 25, "Wizard");
Console.WriteLine(arus);
Console.WriteLine(wizard);
Console.WriteLine(arus.Attack());
Console.WriteLine(wizard.Attack());