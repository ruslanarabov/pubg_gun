using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pubg
{
    public class BulletCountCannotBeZero : Exception
    {
        public BulletCountCannotBeZero()
        {
        }

        public BulletCountCannotBeZero(string? message) : base(message)
        {

        }
    }
}