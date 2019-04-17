
namespace RacingGame
{
    static class Movement
    {
        static void Move(SpaceShip spaceShip)
        {
            if(spaceShip.Position == 0)
            {
                spaceShip.StartPositionY -= 2;
            }

            else if(spaceShip.Position == 4)
            {
                spaceShip.StartPositionX += 2;
            }
        }
    }
}
