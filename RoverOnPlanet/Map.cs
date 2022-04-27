using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoversOnPlanetsKata
{
    public class Map
    {
        int horizontalSize;
        int verticalSize;
        int[,] grid;
        Enum directions;
        Enum moves;

        public Map(int horizontalSize, int verticalSize)
        {
            this.horizontalSize = horizontalSize;
            this.verticalSize = verticalSize;
            this.grid = new int[horizontalSize, verticalSize];
        }
    }
}
