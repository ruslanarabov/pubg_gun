using System;
using pubg;


Console.WriteLine("Welcome to the Weapon Simulator!");
Console.WriteLine();
        
Console.WriteLine("                     ,_______________________________________ ");
Console.WriteLine("       _____________/   |                                    \\");
Console.WriteLine("      | _______     |   |     W E A P O N   S I M U L A T O R  |");
Console.WriteLine("      ||       |    |   |_____________________________________|");
Console.WriteLine("      ||_______|____|_______======*                            |");
Console.WriteLine("      |                 |                                      |");
Console.WriteLine("      |_________________|      ________________________________/");
Console.WriteLine("               /  ||         ||");
Console.WriteLine("      ________/   ||         ||_____________");
Console.WriteLine("     /           _||         ||_            \\");
Console.WriteLine("    /___________/ ||_________|| \\____________\\");
Console.WriteLine("        ||||       ||       ||       ||||");
Console.WriteLine("        ||||       ||       ||       ||||");
Console.WriteLine("        ||||       ||       ||       ||||");
Console.WriteLine("   Get ready to aim and fire!");

Weapon weapon = null;
while (weapon == null)
{
    try
    {
        Console.Write("Enter bullet capacity: ");
        int bulletCapacity = int.Parse(Console.ReadLine());

        if (bulletCapacity <= 0)
        {
            Console.WriteLine("Error: Bullet capacity cannot be zero or negative. Please try again.");
            continue;
        }

        Console.Write("Is the weapon automatic? (yes/no): ");
        bool isAutomatic = Console.ReadLine().ToLower() == "yes";

        weapon = new Weapon(bulletCapacity, isAutomatic);
    }
    catch (BulletCountCannotBeZero ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected error: " + ex.Message);
    }
    
    while (true)
    {
        Console.WriteLine("\nOptions:");
        Console.WriteLine("1 - Shoot");
        Console.WriteLine("2 - Fire (Empty the magazine)");
        Console.WriteLine("3 - Get Remaining Bullet Count");
        Console.WriteLine("4 - Reload");
        Console.WriteLine("5 - Change Fire Mode");
        Console.WriteLine("6 - Exit");
        Console.Write("Choose an option: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            weapon.Shoot();
            break;
            case 2:
            weapon.Fire();
            break;
            case 3:
            int remainingBullets = weapon.GetRemainBulletCount();
            Console.WriteLine($"Remaining bullets to fill the magazine: {remainingBullets}");
            break;
            case 4:
            weapon.Reload();
            break;
            case 5:
            weapon.ChangeFireMode();
            break;
            case 6:
            Console.WriteLine("Exiting the program...");
            return;
            default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
        }
    }
}
        



