// See https://aka.ms/new-console-template for more information

using System;

class JagArr
{


    public static void Main()
    {


        int[][] jaggedArr = new int[4][]; // Making a jagged array with 4 sub arrays

        // entering the values of each sub arrays

        jaggedArr[0] = new int[4] { 5, 6, 7, 8 };
        jaggedArr[1] = new int[3] { 22, 66, 33 };
        jaggedArr[2] = new int[2] { 556, 112 };
        jaggedArr[3] = new int[5] { 5, 55, 22, 31, 97 };

        // this is a new array that will store the largest values from each sub array
        int[] largestNumArr = new int[4];

        for (int i = 0; i < jaggedArr.Length; i++) // for loop iterating through the jagged array
        {
            Array.Sort(jaggedArr[i]);  // sorts sub arrays from smallest to largest number 
            largestNumArr[i] = jaggedArr[i][jaggedArr[i].Length - 1]; // Assigning the number at the end of each sub array to LargestNumArr[i] (- 1 is neccesary because arrays start at 0)
            Console.WriteLine($"The largest number is : {largestNumArr[i]}"); // Printing new array with largest number from each sub array
        }
    }
}

/* I had trouble with visual studio so I have not run this code inside the assessment repository, as I could not figure out how to without breaking it, so it
   May or may not work for you inside this repository, but the code itself was working good outside of this repository.
   
   I created the code in a seperate project in visual studio, got it working perfectly, then pasted my code directly into this github repository on the Github
   website, after creating the JaggedArray.cs file on github.
        
*/      
      
 
  

