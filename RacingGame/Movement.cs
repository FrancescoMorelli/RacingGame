
using System.Windows.Forms;

namespace RacingGame
{
    public static class Movement
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
                    spaceShip.StartPositionY -= 2 * spaceShip.Speed;
                    break;

                case 1:
                    spaceShip.StartPositionX += 1 * spaceShip.Speed;
                    spaceShip.StartPositionY -= 2 * spaceShip.Speed;
                    break;

                case 2:
                    spaceShip.StartPositionX += 2 * spaceShip.Speed;
                    spaceShip.StartPositionY -= 2 * spaceShip.Speed;
                    break;

                case 3:
                    spaceShip.StartPositionX += 2 * spaceShip.Speed;
                    spaceShip.StartPositionY -= 1 * spaceShip.Speed;
                    break;

                case 4:
                    spaceShip.StartPositionX += 2 * spaceShip.Speed;
                    break;

                case 5:
                    spaceShip.StartPositionX += 2 * spaceShip.Speed;
                    spaceShip.StartPositionY += 1 * spaceShip.Speed;
                    break;

                case 6:
                    spaceShip.StartPositionX += 2 * spaceShip.Speed;
                    spaceShip.StartPositionY += 2 * spaceShip.Speed;
                    break;

                case 7:
                    spaceShip.StartPositionX += 1 * spaceShip.Speed;
                    spaceShip.StartPositionY += 2 * spaceShip.Speed;
                    break;

                case 8:
                    spaceShip.StartPositionY += 2 * spaceShip.Speed;
                    break;

                case 9:
                    spaceShip.StartPositionX -= 1 * spaceShip.Speed;
                    spaceShip.StartPositionY += 2 * spaceShip.Speed;
                    break;

                case 10:
                    spaceShip.StartPositionX -= 2 * spaceShip.Speed;
                    spaceShip.StartPositionY += 2 * spaceShip.Speed;
                    break;

                case 11:
                    spaceShip.StartPositionX -= 2 * spaceShip.Speed;
                    spaceShip.StartPositionY += 1 * spaceShip.Speed;
                    break;

                case 12:
                    spaceShip.StartPositionX -= 2 * spaceShip.Speed;
                    break;

                case 13:
                    spaceShip.StartPositionX -= 2 * spaceShip.Speed;
                    spaceShip.StartPositionY -= 2 * spaceShip.Speed;
                    break;

                case 14:
                    spaceShip.StartPositionX -= 2 * spaceShip.Speed;
                    spaceShip.StartPositionY -= 2 * spaceShip.Speed;
                    break;

                case 15:
                    spaceShip.StartPositionX -= 1 * spaceShip.Speed;
                    spaceShip.StartPositionY -= 2 * spaceShip.Speed;
                    break;

            }
        }

    }
}
