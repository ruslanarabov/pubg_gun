using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pubg
{
public interface IAutomatic
{
    int CurrentBulletCount { get; set; }
    public void Fire()
    {
        if (CurrentBulletCount > 0)
        {
            System.Console.WriteLine("Your fired all bullets.");
            CurrentBulletCount = 0;
        }
        else 
        {
            System.Console.WriteLine("No bullets left. Please reload!");
        }
    }

    }
    
}