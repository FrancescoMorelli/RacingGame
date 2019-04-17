
using System.Windows.Forms;

namespace RacingGame
{
    public static class Movement
    {
        public static void Move(SpaceShip spaceShip, KeyEventArgs e)
        {
            var player1KeyPress = e.KeyCode;
            var player2KeyPress = e.KeyCode;

            switch (player1KeyPress)
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
                        break;
                    }
                case Keys.Down:
                case Keys.S:
                    {
                        break;
                    }
            }

        }

    }
}
