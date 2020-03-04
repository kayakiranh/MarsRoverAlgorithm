using System;

namespace MarsRoverAlgorithm.Models
{

    /// <summary>
    /// N/1 - Kuzey
    /// S/2 - Güney
    /// E/3 - Batı
    /// W/4 - Doğu
    /// </summary>
    public enum Directions
    {
        N = 1,
        E = 2,
        S = 3,
        W = 4
    }

    public interface IVehicle
    {
        IPlateau Plateau { get; set; }
        ICoordinate VehicleCoordinate { get; set; }
        Directions VehicleDirection { get; set; }
        void Drive(char[] commands);
    }

    public class Vehicle : IVehicle
    {
        public IPlateau Plateau { get; set; }
        public ICoordinate VehicleCoordinate { get; set; }
        public Directions VehicleDirection { get; set; }

        public Vehicle(IPlateau plateau, ICoordinate vehicleCoordinate, Directions vehicleDirection)
        {
            Plateau = plateau;
            VehicleCoordinate = vehicleCoordinate;
            VehicleDirection = vehicleDirection;
        }

        public void Drive(char[] commands)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'L') GoLeft();
                else if (commands[i] == 'R') GoRight();
                else if (commands[i] == 'M') GoForward();
                else DontMove();
            }
        }

        private void DontMove()
        {
            throw new NotImplementedException();
        }

        private void GoLeft()
        {
            VehicleDirection = (VehicleDirection - 1) < Directions.N ? Directions.W : VehicleDirection - 1;
        }

        private void GoRight()
        {
            VehicleDirection = (VehicleDirection + 1) > Directions.W ? Directions.N : VehicleDirection + 1;
        }

        private void GoForward()
        {
            if (VehicleDirection == Directions.N) { VehicleCoordinate.Y++; Console.WriteLine($"{VehicleCoordinate.X} {VehicleCoordinate.Y} {VehicleDirection}");} 
            else if (VehicleDirection == Directions.E) { VehicleCoordinate.X++; Console.WriteLine($"{VehicleCoordinate.X} {VehicleCoordinate.Y} {VehicleDirection}"); }
            else if (VehicleDirection == Directions.S){VehicleCoordinate.Y--; Console.WriteLine($"{VehicleCoordinate.X} {VehicleCoordinate.Y} {VehicleDirection}"); }
            else if (VehicleDirection == Directions.W){VehicleCoordinate.X--; Console.WriteLine($"{VehicleCoordinate.X} {VehicleCoordinate.Y} {VehicleDirection}"); }
            else { }
        }
    }
}