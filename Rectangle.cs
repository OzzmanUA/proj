using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Rectangle1
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area 
        {
            get { return Width * Height; }
        }
        public Rectangle1(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
