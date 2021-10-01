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

class Solution {

    // Complete the bankersAndClients function below.
    static int totalPairs(int n, List<int> values) {
        return -1;

    }

    static void Main(string[] args) {

		int n = Convert.ToInt32(Console.ReadLine().Trim());
		List<int> values = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = totalPairs(n, values);
        // Do not remove below line
		Console.WriteLine(result);
    }
}