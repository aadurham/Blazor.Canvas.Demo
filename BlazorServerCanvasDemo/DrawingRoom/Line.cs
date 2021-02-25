using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCanvasDemo.DrawingRoom
{
    public class Line
    {
        public int startX { get; set; }
        public int startY { get; set; }
        public int endX { get; set; }
        public int endY { get; set; }
        public int thickness { get; set; }
        public string color { get; set; } = "black";

        public Line(int startx, int starty, int endx, int endy, int lineThickness, string lineColor)
        {
            startX = startx;
            startY = starty;
            endX = endx;
            endY = endy;
            thickness = lineThickness;
            color = lineColor;
        }
    }
}
