using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerD
{
    public class Path
    {
        private MapLocation[] _pathLocations;

        public Path(MapLocation[] pathLocations)
        {
            _pathLocations = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation) => _pathLocations.Contains(mapLocation);

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _pathLocations.Length) ? _pathLocations[pathStep] : null;
        }
    }
}
