using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public static class Utilities
{
    /*EXTRA CREDIT SOLULTION
    {
        public static string SplitAndAnalyzeString(string input)
        {
            input = input.Trim();
            string[] words = input.Split(' ');

            int[] results = (0, 0);

            foreach (var word in words)
            {
                string trimmed = word.Trim();
                if (trimmed.Length > 0)
                {
                    int index = AnalyzeString(word);
                    results[index]++; 
                }
            }

            string resultString = results[0] + "words, " + results[1] + " number ";
            return resultString;
        }
        //Returns 0 if a word, 1 if a number
        private static int AnalyzeString(string input)
        {
            try
            {
                var culture = CultureInfo.CreateSpecificCulture("en-US");
                var number = double.Parse(input, culture);
                return 1;
            }
            catch (System.FormatException)
            {
                return 0;
            }
        }
    }*/

    //Dr. Dan's solution
    public static string ProcessText(string input)
    {
        //Split the string on " "
        //put the string into an array
        //go through the array and do try parse for each
        //if it works increment a number
        //Bonus challenge

        //Basic Logic
        //Return the string 'word' if user enters a word (includes 'ab.23cd')
        //Return the string 'number' if user enters a number (includes decimals, 1.3
        float num;
        if (float.TryParse(input, out num))
        {
            input = "Number";
        }
        else
        {
            input = "String";
        }
        return input;
    }
}

