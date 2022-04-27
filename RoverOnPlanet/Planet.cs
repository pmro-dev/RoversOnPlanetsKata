using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoversOnPlanetsKata
{
    public class Planet
    {
        public Map Map { get ; set; }
        public int VerticalSize { get; set; }
        public int HorizontalSize { get; set; }

        public Planet()
        {
            VerticalSize = 10;
            HorizontalSize = 10;
            Map = new Map(HorizontalSize, VerticalSize);
        }

        public Planet(int verticalSize, int horizontalSize)
        {
            VerticalSize = verticalSize;
            HorizontalSize = horizontalSize;
            Map = new Map(HorizontalSize, VerticalSize);
        }
    }
}
