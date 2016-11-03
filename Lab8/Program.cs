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
            while (playAgain)
            {

                //Total batters stored in array to give total rows, 
                //Array set to 3 columns for Rank|batAvg|slugPercent.
                Console.Write("Enter the total number of batters: ");
                int batterTotal = int.Parse(Console.ReadLine());
               
                
               
                int count=1;
                do 
                {
                    Console.Write("Enter the number of times at bat: ");
               int batCount = int.Parse(Console.ReadLine());
                    //Get total number at-bats.
                    Console.WriteLine("\nRemember:\n0=out, 1=single, 2=double, 3=triple, 4=home run\n");
                    
                    int row = 0;

                    //Console.WriteLine($"Batter number {count} ");//Display batter count number

                    int[] battingInput = new int[batCount];//Batting Average:loop to fill battingInput array until batCount is reached for calculations.

                    //Get batter stats input for each batter until total # of batters is reached|| Display batter count
                    //batterNumber outside forloop for display 2d array
                    Console.WriteLine("Batter number: {0}", count);
                    count++;
                  
                   
                       
                        eachBatterInput(batCount, battingInput);//Calls method to get user input and puts into array.
                       
                    
                  
                    int sum = SumMethod(battingInput);
                    int nonZero = nonZeroMethod(battingInput);

                    float percentAge = ((float)sum / batCount);         //casting: make sum a float
                    float batAge = ((float)nonZero / (float)batCount);

                    Console.WriteLine("Batting Average: {0}", batAge);// float battingAverage = battingInput / batCount;
                    Console.WriteLine("Slugging Percentage: {0}",percentAge);  //find number of nonzero values in battinginput / batCount


                     //DisplayResults(, , percentAge);
                    //Console.WriteLine(display);
                    //foreach (var item in collection)
                    //{

                    //}

                    //count++;
                   
                }while (count <= batterTotal) ;
           
            Console.WriteLine("Do you want to continue using the Batting Average Calculator?!");
            string agree = Console.ReadLine();

            if (agree == "y" || agree == "Y" || agree == "YES" || agree == "yes" || agree == "yeah" | agree == "ok" || agree == "k")
            {
                playAgain = true;
            }
            else
                    playAgain = false;

            }



        }
        //Method to add user inputted batting stats into a 1 dimensional array, 1 row of values
        private static void eachBatterInput(int batCount, int[] battingInput)
        {
           
            int row;
            for (row = 0; row < batCount; row++)
            {
                Console.Write("Enter the result for at-bat number {0}: ",row+1);
                string userbattingInput = Console.ReadLine();
                
                int eachAtBat = int.Parse(userbattingInput);

                //Enters user input into array.
                battingInput[row] = eachAtBat;
               
            }

           
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

        //Method to input stats into an 2d array of 4 columns for |sorting |batter number| batting average | hbatting percentage|
        //# of rows depends on number of batters
        public static int DisplayResults(int batterNumber, int batAge, int percentAge)
        {
            int sortedRank = 1;
            int[,] displayArray = new int[batterNumber, 4];

            displayArray[batterNumber, 0] = sortedRank;
            displayArray[batterNumber, 1] = batterNumber;
            displayArray[batterNumber, 2] = batAge;
            displayArray[batterNumber, 3] = percentAge;

            Console.WriteLine("Rank".PadLeft(- 10) + "Batter#".PadLeft(-10) + "batting average".PadLeft(-10) + "Batting Percentage".PadLeft(-10));
            Console.WriteLine("=======".PadLeft(-10) + "=======".PadLeft(-10) + "=======".PadLeft(-10) + "=======".PadLeft(-10));
            return  displayArray[batterNumber,4];
            //Console.WriteLine(displayArray);
        }




        ////Method to sort best stats
        //public static sortingMethod(int batAge, int percentAge)
        //{
        //    //use array to find the best combination of both
        //}

    }














}











