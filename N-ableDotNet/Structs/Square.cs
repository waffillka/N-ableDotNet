namespace N_ableDotNet.Structs
{
    public class Square
    {
        private readonly Point pointLeftUp;
        private readonly Point pointRightDown;

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
