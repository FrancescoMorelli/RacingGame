
using System.Drawing;
using System.Windows.Forms;

namespace RacingGame
{
    public static class Mechanics
    {
        public static void Rotation(SpaceShip spaceShip, KeyEventArgs e)
        {
            var playerKeyPress = e.KeyCode;

            switch (playerKeyPress)
            {
                case Keys.Right:
                case Keys.D:
                    {
                        if (spaceShip.Position < 15)
                            spaceShip.Position += 1;

                        else
                            spaceShip.Position = 0;
                        break;
                    }

                case Keys.Left:
                case Keys.A:
                    {
                        if (spaceShip.Position > 0)
                            spaceShip.Position -= 1;
                        else
                            spaceShip.Position = 15;
                        break;
                    }
                case Keys.Up:
                case Keys.W:
                    {
                        if (spaceShip.Speed <= 9)
                            spaceShip.Speed += 1;
                        break;
                    }
                case Keys.Down:
                case Keys.S:
                    {
                        if (spaceShip.Speed >= 1)
                            spaceShip.Speed -= 1;
                        break;
                    }
            }
        }

        public static void Move(SpaceShip spaceShip)
        {
            switch (spaceShip.Position)
            {
                case 0:
                    spaceShip.PositionY -= 2 * spaceShip.Speed;
                    break;

                case 1:
                    spaceShip.PositionX += 1 * spaceShip.Speed;
                    spaceShip.PositionY -= 2 * spaceShip.Speed;
                    break;

                case 2:
                    spaceShip.PositionX += 2 * spaceShip.Speed;
                    spaceShip.PositionY -= 2 * spaceShip.Speed;
                    break;

                case 3:
                    spaceShip.PositionX += 2 * spaceShip.Speed;
                    spaceShip.PositionY -= 1 * spaceShip.Speed;
                    break;

                case 4:
                    spaceShip.PositionX += 2 * spaceShip.Speed;
                    break;

                case 5:
                    spaceShip.PositionX += 2 * spaceShip.Speed;
                    spaceShip.PositionY += 1 * spaceShip.Speed;
                    break;

                case 6:
                    spaceShip.PositionX += 2 * spaceShip.Speed;
                    spaceShip.PositionY += 2 * spaceShip.Speed;
                    break;

                case 7:
                    spaceShip.PositionX += 1 * spaceShip.Speed;
                    spaceShip.PositionY += 2 * spaceShip.Speed;
                    break;

                case 8:
                    spaceShip.PositionY += 2 * spaceShip.Speed;
                    break;

                case 9:
                    spaceShip.PositionX -= 1 * spaceShip.Speed;
                    spaceShip.PositionY += 2 * spaceShip.Speed;
                    break;

                case 10:
                    spaceShip.PositionX -= 2 * spaceShip.Speed;
                    spaceShip.PositionY += 2 * spaceShip.Speed;
                    break;

                case 11:
                    spaceShip.PositionX -= 2 * spaceShip.Speed;
                    spaceShip.PositionY += 1 * spaceShip.Speed;
                    break;

                case 12:
                    spaceShip.PositionX -= 2 * spaceShip.Speed;
                    break;

                case 13:
                    spaceShip.PositionX -= 2 * spaceShip.Speed;
                    spaceShip.PositionY -= 2 * spaceShip.Speed;
                    break;

                case 14:
                    spaceShip.PositionX -= 2 * spaceShip.Speed;
                    spaceShip.PositionY -= 2 * spaceShip.Speed;
                    break;

                case 15:
                    spaceShip.PositionX -= 1 * spaceShip.Speed;
                    spaceShip.PositionY -= 2 * spaceShip.Speed;
                    break;
            }
        }
        static public void Collision(SpaceShip spaceShip, Rectangle outBoundaries, Rectangle inBoundaries)
        {
            Rectangle playerShip = new Rectangle(spaceShip.PositionX, spaceShip.PositionY, 40, 40);

            if (!outBoundaries.Contains(playerShip) || inBoundaries.IntersectsWith(playerShip))
            {
                spaceShip.Position = 4;
                spaceShip.Speed = 0;
                spaceShip.PositionX = 650;
                if (spaceShip.PlayerNumber == 1)
                    spaceShip.PositionY = 480;
                else
                    spaceShip.PositionY = 540;
            }
        }
    }
}
