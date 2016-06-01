using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestDevelopersBay
{
    using System;

    public static class Vectors
    {
        public static int[] FindShortest(int[][] vectors)
        {
            var numberOfVectors = vectors.Count();
            var lengtPerVector = new List<KeyValuePair<int, int>>(numberOfVectors);

            for(int i = 0; i < vectors.Count(); i++)
            {
                var vector = vectors[i];
                var length = LengthOfVector(vector);
                lengtPerVector.Add(new KeyValuePair<int, int>(i, length));
                
            }

            return null;
        }

        public static int LengthOfVector(int[] vector)
        {
            if(vector == null || vector.Count() != 3)
            {
                throw new Exception("Invalid vector");
            }

            var x = vector[0];
            var y = vector[1];
            var z = vector[2];

            var xPow = Math.Pow(x, 2);
            var yPow = Math.Pow(y, 2);
            var zPow = Math.Pow(z, 2);

            return (int) Math.Sqrt(xPow + yPow + zPow);
        }

        public static void Main(string[] args)
        {
            int[][] vectors = 
            {
                new int[] { 1, 1, 1 },
                new int[] { 2, 2, 2 },
                new int[] { 3, 3, 3 }
            };

            int[] shortest = Vectors.FindShortest(vectors);
            // Expected output: x: 1, y: 1, z: 1
            Console.WriteLine(String.Format("x: {0}, y: {1}, z: {2}", shortest[0], shortest[1], shortest[2]));
        }
    }
}
