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
    static int bankersAndClients(int c,int b,int[][] container) {
        return -1;

    }

    static void Main(string[] args) {

		int[] ar = new int[2];
		ar = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
		int c = ar[0];
		int b = ar[1];
		int[][] container = new int[b][];

		for (int i = 0; i < b; i++) {
			container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
		}

		int result = bankersAndClients(c,b,container);
            
        // Do not remove below line
		Console.WriteLine(result);
        // Do not print anything after this line

    }
}