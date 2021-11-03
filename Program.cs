using System;
using System.Linq;

namespace Monte_Carlo
{
    static class Program
    {
        static void Main()
        {
            var random = new Random();
            
            const int r = 1;
            var pointsIn = 0.0;
            var allPoints = 0.0;

            foreach (var itering in Enumerable.Range(0, 1000))
            {
                var newPointX = random.NextDouble();
                var newPointY = random.NextDouble();
                
                pointsIn += PointIsInCircle(newPointX, newPointY, r) ? 1 : 0;
                
                allPoints += 1;
            }

            var estimation =  4 * pointsIn/allPoints;
            
            Console.WriteLine($"Estimation of pi: {estimation}");
        }

        private static bool PointIsInCircle(double x, double y, int r) =>
            x*x + y*y < r;
    }
}
