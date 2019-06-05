namespace Metody_2
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newLocation)
        {
            if (newLocation == null)
            {
                System.Console.WriteLine("błąd");
                return;
            }
            Move(newLocation.X, newLocation.Y);
        }


    }


}
