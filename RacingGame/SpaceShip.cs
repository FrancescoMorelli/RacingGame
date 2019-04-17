using System.Drawing;

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

            for (int i = 0; i < ShipImage.Length; i++)
            {
                ShipImage[i] = Image.FromFile(@"F:\JavaAssignment_SID_1425330\SpaceShipImages/SpaceShip" + playerNumber + "_" + i + ".png");
            }
        }
    }
}
