import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Solution {

    static int totalPairs(int n, int[] values) {
        // Complete the total Pairs function below
        return -1;

    }

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int n = Integer.parseInt(br.readLine());
        int[] values = new int[n];
        String[] temp = br.readLine().split(" ");
        for (int i = 0; i < n; ++i) {
            values[i] = Integer.parseInt(temp[i]);
        }

        int answer = totalPairs(n, values);
        System.out.println(answer);
    }
}
