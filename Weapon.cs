using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pubg;

namespace pubg
{

}
public class Weapon
{
    private int _currentBulletCount;
    private int _bulletCapacity;
    public bool IsAutomatic { get; set; }
    public int CurrentBulletCount
    {
        get => _currentBulletCount;
        set
        {
            if (value >= 0)
            {
                _currentBulletCount = value;
            }
            else
            {
                System.Console.WriteLine("Bullet Count can not negative.");
            }
        }
    }
    public int BulletCapacity 
    {
        get => _bulletCapacity;
        set
        {
            if (value >= 0)
            {
                _bulletCapacity = value;
            }
            else
            {
                System.Console.WriteLine("Bullet Capacity can not be negative.");
            }
        }
    }
  
    public Weapon(int bulletCapacity, bool isAutomatic)
    {
        if (bulletCapacity < 0)
        {
            throw new BulletCountCannotBeZero("Bullet cannot be 0.");
        }   
        BulletCapacity = bulletCapacity;
        IsAutomatic = isAutomatic;
        CurrentBulletCount = bulletCapacity; 
    }
    public void Shoot()
    {
        if (CurrentBulletCount > 0)
        {
            CurrentBulletCount--;
            Console.WriteLine("Shot fired! Remaining bullets: " + CurrentBulletCount);
        }
        else
        {
            System.Console.WriteLine("No bullets left. Please reload!");
        }
    }
    public void Fire()
    {
        if (CurrentBulletCount > 0)
        {
            if (IsAutomatic)
            {
                Console.WriteLine($"You fired all bullets. {CurrentBulletCount} bullets fired!");
                CurrentBulletCount = 0;
            }
            else
            {
                Console.WriteLine("Cannot fire all bullets in Single mode. Use Shoot() instead.");
            }
        }
        else
        {
            System.Console.WriteLine("No bullets left, please reload.");
        }      
    }
    public int GetRemainBulletCount()
    {
        return BulletCapacity - CurrentBulletCount;
    }
    public void Reload()
    {
        CurrentBulletCount = BulletCapacity;
        Console.WriteLine("Weapon is reloaded. Current bullet: " + CurrentBulletCount);
    }
    public void ChangeFireMode()
    {
        IsAutomatic = !IsAutomatic;
        string mode = IsAutomatic ? "Automatic" : "Single shot";
        Console.WriteLine("Fire mode changed to: " + mode);
    }
}
    
