namespace Structures
{
    public static class DirectionExtensions
    {
        public static Direction OppositeDirection(this Direction direction) => direction switch
        {
            Direction.Up => Direction.Down,
            Direction.Left => Direction.Right,
            Direction.Down => Direction.Up,
            Direction.Right => Direction.Left,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}