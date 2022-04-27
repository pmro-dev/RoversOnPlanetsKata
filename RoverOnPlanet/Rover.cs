using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoversOnPlanetsKata
{
    public class Rover
    {
        private Enum directions;
        private Enum moveTypes;

        public Enum Directions { get => directions; set => directions = value; }
        public Enum MoveTypes { get => moveTypes; set => moveTypes = value; }
    }
}
