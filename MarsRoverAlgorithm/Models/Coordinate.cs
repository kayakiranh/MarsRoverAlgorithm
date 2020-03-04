namespace MarsRoverAlgorithm.Models
{
    /// <summary>
    /// 0,0 = Sol Alt Köşe
    /// </summary>
    public interface ICoordinate
    {
        int X { get; set; }
        int Y { get; set; }
    }

    public class Coordinate : ICoordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}