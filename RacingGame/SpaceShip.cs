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
        public int LapCount { get; set; }
        public bool CheckPointFlag { get; set; }


        public SpaceShip(int playerNumber, int startPositionX, int startPositionY)
        {
            PositionX = startPositionX;
            PositionY = startPositionY;
            PlayerNumber = playerNumber;
            Position = 4;
            Speed = 0;

            ShipImage = new Image[16];

            string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            DirectoryInfo binDir = Directory.GetParent(exeDir);
            string shipsDir = Path.Combine(binDir + @"\SpaceShipImages\SpaceShip");

            for (int i = 0; i < ShipImage.Length; i++)
            {
                ShipImage[i] = Image.FromFile(shipsDir + playerNumber + "_" + i + ".png");
            }
        }

        public Rectangle SpaceShipRectangle()
        {

            Rectangle shipRectangle = new Rectangle(PositionX, PositionY, 35, 35);

            return shipRectangle;
        }
    }
}
