using System;
using MarsRoverAlgorithm.Models;

namespace MarsRoverAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plateau Coordinate : 5 5");

            Console.WriteLine("First Vehicle : ");
            Console.WriteLine("Vehicle Coordinate : 1 2 N");
            Console.WriteLine("Vehicle Commands : LMLMLMLMM");
            Console.WriteLine("Second Vehicle : ");
            Console.WriteLine("Vehicle Coordinate : 3 3 E");
            Console.WriteLine("Vehicle Commands : MMRMMRMRRM");
            Console.WriteLine();

            Plateau plateau = new Plateau(new Coordinate(5, 5));
            Vehicle firstVehicle = new Vehicle(plateau, new Coordinate(1, 2), Directions.N);
            Vehicle secondVehicle = new Vehicle(plateau, new Coordinate(3, 3), Directions.E);

            Console.WriteLine("Expected Output :");
            Console.WriteLine("First Vehicle Detail :");
            firstVehicle.Drive(new char[] { 'L', 'M', 'L', 'M', 'L', 'M', 'L', 'M', 'M' });
            Console.WriteLine($"First Vehicle Result : {firstVehicle.VehicleCoordinate.X} {firstVehicle.VehicleCoordinate.Y} {firstVehicle.VehicleDirection}");

            Console.WriteLine("Second Vehicle Detail :");
            secondVehicle.Drive(new char[] { 'M', 'M', 'R', 'M', 'M', 'R', 'M', 'R', 'R', 'M' });
            Console.WriteLine($"Second Vehicle Result : {secondVehicle.VehicleCoordinate.X} {secondVehicle.VehicleCoordinate.Y} {secondVehicle.VehicleDirection}");

            Console.ReadLine();
        }
    }
}