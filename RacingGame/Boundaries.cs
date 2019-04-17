namespace RacingGame
{
    public class Boundaries
    {
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public Boundaries(int startPoint, int endPoint, int width, int height)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Height = height;
            this.Width = width;

        }
    }
}
