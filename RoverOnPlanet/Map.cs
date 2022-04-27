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

        public int HorizontalSize { get => horizontalSize; set => horizontalSize = value; }
        public int VerticalSize { get => verticalSize; set => verticalSize = value; }
        public int[,] Grid { get => grid; set => grid = value; }

        public Map(int horizontalSize, int verticalSize)
        {
            this.HorizontalSize = horizontalSize;
            this.VerticalSize = verticalSize;
            this.Grid = new int[horizontalSize, verticalSize];
        }


    }
}
