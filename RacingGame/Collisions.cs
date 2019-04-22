using System.Drawing;

namespace RacingGame
{
    public class Collisions
    {
        static public void Walls(SpaceShip spaceShip, Rectangle outBoundaries, Rectangle inBoundaries)
        {
            Rectangle playerShip = spaceShip.SpaceShipRectangle();

            if (!outBoundaries.Contains(playerShip) || inBoundaries.IntersectsWith(playerShip))
            {
                RestartPositions(spaceShip);
            }
        }

        static public void Players(SpaceShip spaceShip1, SpaceShip spaceShip2)
        {
            Rectangle playerShip1 = spaceShip1.SpaceShipRectangle();
            Rectangle playerShip2 = spaceShip2.SpaceShipRectangle();

            if (playerShip1.IntersectsWith(playerShip2))
            {
                RestartPositions(spaceShip1);
                RestartPositions(spaceShip2);
            }
        }

        static public void RestartPositions(SpaceShip spaceShip)
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
