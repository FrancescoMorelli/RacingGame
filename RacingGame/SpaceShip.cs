using System.Drawing;
using System.Reflection;
using System.IO;

namespace RacingGame
{
    public class SpaceShip
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Image[] ShipImage { get; set; }
        public int Position { get; set; }
        public int Speed { get; set; }
        public int PlayerNumber { get; }

        public SpaceShip(int playerNumber, int startPositionX, int startPositionY)
        {
            this.PositionX = startPositionX;
            this.PositionY = startPositionY;
            this.PlayerNumber = playerNumber;
            Position = 4;
            Speed = 1;

            ShipImage = new Image[16];

            string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            DirectoryInfo binDir = Directory.GetParent(exeDir);
            string shipsDir = Path.Combine(binDir + @"\SpaceShipImages\SpaceShip");


            for (int i = 0; i < ShipImage.Length; i++)
            {
                ShipImage[i] = Image.FromFile(shipsDir + playerNumber + "_" + i + ".png");
            }
        }

        public Rectangle DrawSpaceShipRectangle()
        {

            Rectangle shipRectangle = new Rectangle(this.PositionX, this.PositionY, 35, 35);

            return shipRectangle;
        }
    }
}
