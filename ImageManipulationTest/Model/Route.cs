using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationTest.Model
{
    public class Route
    {
        public string RouteName { get; set; }
        public Image Floorplan { get; set; }
        public List<WalkingPath> Paths { get; set; }

        public Route( string routeName, Image floorplan, List<WalkingPath> paths)
        {
            RouteName = routeName;
            Floorplan = floorplan;
            Paths = paths;
        }
    }

}
