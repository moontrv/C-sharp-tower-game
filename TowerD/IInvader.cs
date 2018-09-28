using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerD
{
    public interface IInvader
    {
        MapLocation Location { get; }
        bool HasScored { get; }
        int Health { get; }
        bool IsNeutralized { get; }
        bool IsActive { get; }

        void DecreaseHealth(int factor);
        void Move();
    }
}
