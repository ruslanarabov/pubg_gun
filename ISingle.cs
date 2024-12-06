using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pubg
{
    public interface ISingle
    {
    int CurrentBulletCount { get; set; }

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
    }
}