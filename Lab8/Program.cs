using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        public static int sluggingPercentage { get; private set; }

        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Batting Average Calculator!");

            //Total batters stored in array to give total rows, 
            //Array set to 3 columns for Rank|batAvg|slugPercent.
            Console.WriteLine("Enter total number of batters: ");
            int batterTotal = int.Parse(Console.ReadLine());
            int[,] stats = new int[batterTotal, 3];

            //Get total number at-bats
            Console.WriteLine("\n \n0=out, 1=single, 2=double, 3=triple, 4=home run");
            Console.WriteLine("Enter number of times at bat: ");
            int batCount = int.Parse(Console.ReadLine());
            int row = 0;

            //Batting Average:
            //loop to fill battingInput array until batCount is reached for calculations
            int[] battingInput = new int[batCount];

            for (row = 0; row < batCount; row++)
            {
                Console.Write($"Result for at-bat {row}: ", row);
                string userbattingInput = Console.ReadLine();
                int eachAtBat = int.Parse(userbattingInput);

               battingInput[row] = eachAtBat;//enters user input into array
            }
            
            int sum = SumMethod (battingInput);
            int nonZero = nonZeroMethod(battingInput);

            float percentAge = ((float)sum / batCount);
            float batAge = ((float)nonZero/batCount);

            // float battingAverage = battingInput / batCount;
            //find number of nonzero values in battinginput / batCount

            Console.WriteLine($"Batting Average: {batAge}");
            Console.WriteLine($"Slugging Percentage: {percentAge}");

        }



        
       public static int SumMethod (int[] battingValue)
       {
                int sum = 0;
            foreach (int slug in battingValue)
            {
                sum += slug;
            }
                 return sum;
       }

        public static  int nonZeroMethod(int[] battingValue)
        {
                 int sum = 0;
            foreach (int slug in battingValue)
            {
                if (slug != 0)
                {
                    sum++;
                }
            }
                  return sum;
        }
                






    }














}
           






    

    

