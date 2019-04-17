using System.Drawing;

namespace RacingGame
{
    public class SpaceShip
    {
        public int StartPositionX { get; set; }
        public int StartPositionY { get; set; }
        public Image[] ShipImage { get; set; }
        public int Position { get; set; }
        public int Speed { get; set; }

        public SpaceShip(int playerNumber, int startPositionX, int startPositionY)
        {
            this.StartPositionX = startPositionX;
            this.StartPositionY = startPositionY;
            Position = 4;
            Speed = 1;

            ShipImage = new Image[16];

            for (int i = 0; i < ShipImage.Length; i++)
            {
                ShipImage[i] = Image.FromFile(@"F:\JavaAssignment_SID_1425330\SpaceShipImages/SpaceShip" + playerNumber + "_" + i + ".png");
            }
        }

        public void Acceleration()
        {

        }

        public void Deceleration()
        {

        }
    }

}
