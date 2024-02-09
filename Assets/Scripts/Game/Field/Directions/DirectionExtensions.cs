namespace TicTacToe
{
    public static class DirectionExtensions
    {
        public static Direction Opposite(this Direction direction)
        {
            return (int)direction > 4 ? direction - 4 : direction + 4;
        }
    }
}
