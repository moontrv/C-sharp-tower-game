﻿using TowerD.Tests.Mocks;
using Xunit;
using TowerD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerD.Tests
{
    public class TowerTests
    {
        public class TowerTests
        {
            [Fact()]
            public void FireOnInvadersDecreasesInvadersHealth()
            {
                var map = new Map(3, 3);
                var target = new Tower(new MapLocation(0, 0, map));

                var invaders = new InvaderMock[]
                {
                new InvaderMock() { Location = new MapLocation(0, 0, map) },
                new InvaderMock() { Location = new MapLocation(0, 0, map) }
                };

                target.FireOnInvaders(invaders);

                Assert.All(invaders, i => Assert.Equal(1, i.Health));
            }
        }
    }
}