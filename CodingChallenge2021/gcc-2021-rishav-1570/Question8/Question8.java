import java.io.*;
import java.util.*;
import java.util.stream.Stream;

class Solution {

    // You may change this function parameters
    static int calculateMaximizedReturns(int n, int k, int d, int m, int[] dailyReturns) {
        // Participant's code will go here
        return -1;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        String[] firstLine = scanner.nextLine().split(" ");
        String[] secondLine = scanner.nextLine().split(" ");
        scanner.close();

        int n = Integer.parseInt(firstLine[0]);
        int k = Integer.parseInt(firstLine[1]);
	int k = Integer.parseInt(firstLine[2]);
	int k = Integer.parseInt(firstLine[3]);
        int[] dailyReturns = Stream.of(secondLine).mapToInt(Integer::parseInt).toArray();
       
        int result = calculateMaximizedReturns(n, k, d, m, dailyReturns);
        // Please do not remove the below line.
        System.out.println(result);
        // Do not print anything after this line
    }
}