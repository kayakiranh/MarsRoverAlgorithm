namespace MarsRoverAlgorithm.Models
{
    public interface IPlateau
    {
        Coordinate PlateauCoordinate { get; }
    }

    public class Plateau : IPlateau
    {
        public Coordinate PlateauCoordinate { get; set; }

        public Plateau(Coordinate coordinate)
        {
            PlateauCoordinate = coordinate;
        }
    }
}