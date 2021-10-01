import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Solution {

    // Complete the banker_and_client function below.
    static int bankerAndClient(int c, int b, int[][] time) {
        return -1;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {

        Scanner in = new Scanner(System.in);
        int c = in.nextInt();
        int b = in.nextInt();
        int answer;
            int[][] M = new int[b][c];
            for(int i=0; i < b; i++)
                for(int j=0; j < c; j++)
                    M[i][j] = in.nextInt();
            answer= bankerAndClient(c,b,M);
        // Do not remove below line
	    System.out.println(answer);
        // Do not print anything after this line
		
        scanner.close();
    }
}
