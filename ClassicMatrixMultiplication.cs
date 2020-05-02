using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime;   // start/stop time for the loop
            DateTime endTime;
            TimeSpan timeDifference;
            double seconds = 0;

            for (int n = 2; seconds < 600; n = n * 2)
            {
                int[,] firstMatrix = new int[n,n];
                int[,] secondMatrix = new int[n,n];
                int[,] resultMatrix = new int[n,n];     //creating 3 2-D arrays for multiplication

                Random r = new Random();
                int Low = 1;
                int High = 10;         //bounds for randomized numbers
                Console.WriteLine("Current size: " + n + " x " + n + "---");        //print size of matrix

                //fill 1st
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        firstMatrix[i,j] = r.Next(High - Low) + Low;
                    }
                }

                //fill 2nd
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        secondMatrix[i,j] = r.Next(High - Low) + Low;
                    }
                }

                startTime = DateTime.UtcNow;
                //Matrix Mulitplication Process
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for(int k = 0; k < n; k++)
                        {
                            resultMatrix[i,j] = resultMatrix[i,j] + firstMatrix[i,k] * secondMatrix[k,j];
                        }
                    }
                }
                endTime = DateTime.UtcNow;
                timeDifference = endTime - startTime;
                seconds = timeDifference.TotalSeconds;
                Console.WriteLine("Total time for multiplication: " + seconds);
            }
            Console.WriteLine("Done!");
        }
    }

}
