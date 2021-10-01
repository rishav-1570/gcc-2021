using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Solution
{

    class Solution
    {

        // You may change this function parameters
        static int calculateMaximizedReturns(int n, int k, int d, int m, int[] returns)
        {
            // Participant's code will go here
            return -1;
        }

        private static int[][] parsePreferences(String[] preferences)
        {
            return preferences.Select(preference =>
            {
                String[] preferenceArr = preference.Split("&");
                return Array.ConvertAll(preferenceArr, sTemp => int.Parse(sTemp));
            }).ToArray();
        }

        static void Main(string[] args)
        {
            String[] firstLine = Console.ReadLine().Split(" ");
            String[] secondLine = Console.ReadLine().Split(" ");

            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);
	    int d = int.Parse(firstLine[2]);
	    int m = int.Parse(firstLine[3]);
            int[] returns = Array.ConvertAll(secondLine, sTemp => int.Parse(sTemp));
          
            int result = calculateMaximizedReturns(n, k, d, m, returns);

            // Please do not remove the below line.
            Console.WriteLine(result);
            // Do not print anything after this line
        }
    }
}