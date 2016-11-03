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
            //while user wants to continue
            bool playAgain = true;
            while(playAgain)
            {

            //Total batters stored in array to give total rows, 
            //Array set to 3 columns for Rank|batAvg|slugPercent.
            Console.Write("Enter the total number of batters: ");
            int batterTotal = int.Parse(Console.ReadLine());
            //int[,] stats = new int[batterTotal, 3];

            int count = 1;
                while (count < batterTotal)
                {
                    //Get total number at-bats.
                    Console.WriteLine("\nRemember:\n0=out, 1=single, 2=double, 3=triple, 4=home run\n");
                    Console.Write("Enter the number of times at bat: ");
                    int batCount = int.Parse(Console.ReadLine());
                    int row = 0;

                    //Console.WriteLine($"Batter number {count} ");//Display batter count number

                    int[] battingInput = new int[batCount];//Batting Average:loop to fill battingInput array until batCount is reached for calculations.

                    //Get batter stats input for each batter until total # of batters is reached|| Display batter count
                    for (int batterNumber= 1; batterNumber<= batterTotal; batterNumber++)
                    {Console.WriteLine($"Batter number: {count}");
                    row = eachBatterInput(batCount, battingInput);//Calls method to get user input .
                        count++;
                    }

                    int sum = SumMethod(battingInput);
                    int nonZero = nonZeroMethod(battingInput);

                    float percentAge = ((float)sum / batCount);         //casting: make sum a float
                    float batAge = ((float)nonZero / batCount);

                    Console.WriteLine($"Batting Average: {batAge}");// float battingAverage = battingInput / batCount;
                    Console.WriteLine($"Slugging Percentage: {percentAge}");  //find number of nonzero values in battinginput / batCount

                    count++;
                   }
                }
            Console.WriteLine("Do you want to continue using the Batting Average Calculator?!");
                string agree= Console.ReadLine();

                if (agree == "y" || agree == "Y" || agree == "YES" || agree == "yes" || agree == "yeah" | agree == "ok" || agree == "k")
                {
                    playAgain = true;
                }
                else{
                playAgain = false;
                }
            



        }
        //Method to add user inputted batting stats into a 1 dimensional array, 1 row of values
        private static int eachBatterInput(int batCount, int[] battingInput)
        {
            int countTimes = 1;
            int row;
            for (row = 0; row < batCount; row++)
            {
                Console.Write($"Enter the result for at-bat number {countTimes}: ");
                string userbattingInput = Console.ReadLine();
                int eachAtBat = int.Parse(userbattingInput);
                //Enters user input into array.
                battingInput[row] = eachAtBat;
                countTimes++;
            }

            return row;
        }




        //Method to sum values in 1d array.
        public static int SumMethod(int[] battingValue)
        {
            int sum = 0;
            foreach (int slug in battingValue)
            {
                sum += slug;
            }
            return sum;
        }
        //Batting Average calculation: method to find which batting stats are zero. 
        public static int nonZeroMethod(int[] battingValue)
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


        //goals:                                                                                                                               




    }














}
           






    

    

