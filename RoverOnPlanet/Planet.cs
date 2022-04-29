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
        public int VerticalSize { get => verticalSize; set => verticalSize = value; }
        public int HorizontalSize { get => horizontalSize; set => horizontalSize = value; }
        int horizontalSize;
        int verticalSize;

        public Planet()
        {
            verticalSize = 10;
            horizontalSize = 10;
            Map = new Map(this.horizontalSize, this.verticalSize);
        }

        public Planet(int verticalSize, int horizontalSize)
        {
            this.verticalSize = verticalSize;
            this.horizontalSize = horizontalSize;
            Map = new Map(this.horizontalSize, this.verticalSize);
        }
    }
}
