using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            System.Console.WriteLine(TossMultipleCoins(3));
            Names();
        }
        static int[] RandomArray() {
            int[] output = new int[10];
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            Random rand = new Random();

            for ( int i = 0; i < 10; i++ ){
                output[i] = rand.Next(5,25);
                sum += output[i];
                if ( output[i] > max ) {
                    max = output[i];
                }
                if ( output[i] < min ) {
                    min = output[i];
                }
            }
            System.Console.WriteLine($"{min}, {max}, {sum}");
            return output;
        }

        static string TossCoin() {
            System.Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            string result = "";
            if ( rand.Next(1,3) == 1 ) {
                result = "Heads";
            }
            else {
                result = "Tails";
            }
            System.Console.WriteLine(result);
            return result;
        }
        static double TossMultipleCoins(int num) {
            int heads = 0;
            for( int i = 0; i < num; i++) {
                if ( TossCoin() == "Heads" ) {
                    heads++;
                }
            }
            System.Console.WriteLine(heads);
            return (double)heads / num;
        }
        static List<string> Names() {
            List<string> myList= new List<string> {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            List<string> output = new List<string>();
            Random rand = new Random();
            for( int i = 0; i < myList.Count; i++ ) {
                int swapIndex = rand.Next(0, myList.Count);
                // System.Console.WriteLine($"{swapIndex} swapindex");
                string temp = myList[swapIndex];
                myList[swapIndex] = myList[i];
                myList[i] = temp;
            }
            for( int i = 0; i < myList.Count; i++ ) {
                System.Console.WriteLine(myList[i]);
                if ( myList[i].Length > 5) {
                    output.Add(myList[i]);
                }
            }
            return output;
        }
    }
}
