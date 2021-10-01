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

class Result
{

   
    public static int portfolio_profit_maximisation(int maxSum, List<long> a, List<long> b)
    {
        //write your code here
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int maxSum = Convert.ToInt32(firstMultipleInput[2]);

        List<long> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert
        .ToInt64(aTemp)).ToList();

        List<long> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert
        .ToInt64(bTemp)).ToList();

        int result = Result.portfolio_profit_maximisation(maxSum, a, b);

        Console.WriteLine(result);
    }
}
