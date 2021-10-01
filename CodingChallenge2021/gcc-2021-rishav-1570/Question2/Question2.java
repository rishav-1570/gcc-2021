import java.io.*;
import java.util.*;



class Solution {

    static int securitiesBuying(int z, ArrayList<Integer> security_value)
    {
        int no_of_stocks=0;
          // participants code here

        return no_of_stocks;
    }
 

    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        int z = scanner.nextInt();
        scanner.nextLine();
        String str = scanner.nextLine();
        String[] price_str =str.split(" ");  
        ArrayList<Integer> security_value =new ArrayList<Integer>();
        for (String s: price_str){security_value.add(Integer.parseInt(s));}
        int no_of_stocks_purchased = securitiesBuying(z,security_value);
        System.out.println(no_of_stocks_purchased);

        
    }
}
