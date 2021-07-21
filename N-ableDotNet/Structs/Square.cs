using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ableDotNet.Structs
{
    class Square
    {
        private Point pointLeftUp; 
        private Point pointRightDown;

        public Square(Point pointLeftUp, Point pointRightDown)
        {
            this.pointLeftUp = pointLeftUp;
            this.pointRightDown = pointRightDown;
        }

        public Square(int x1, int y1, int x2, int y2)
        {
            pointLeftUp = new Point(x1, y1);
            pointRightDown = new Point(x2, y2);
        }

        public int GetArea()
        {
            return (pointRightDown.X - pointLeftUp.X) * (pointLeftUp.Y - pointRightDown.Y);
        }

        public int GetPerimeter()
        {
            return 2 * (pointRightDown.X - pointLeftUp.X) + 2 * (pointLeftUp.Y - pointRightDown.Y);
        }
    }
}
