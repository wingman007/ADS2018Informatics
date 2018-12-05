import java.util.Stack;

/**
 * Created by Ralitsa Tamashova on 31.10.2018 г..
 */
public class BinaryDecimal {

    public static void main(String[] args) {
        decimalToBinary(85);
        binaryToDecimal("0010");

    }

    public static void binaryToDecimal(String binary) {
        int len = binary.length();
        double decimal = 0;
        for(int i = len-1; i >= 0; i--) {
            if (binary.charAt(i) == '1') {
                decimal = decimal + Math.pow(2, len-i-1);
            }
        }
        System.out.println(decimal);
    }

    public static void decimalToBinary(int decimal) {

        Stack<Integer> binary = new Stack<>();

        do {
            int bit = decimal%2;
            decimal/=2;
            binary.add(bit);
        } while (decimal != 0);

        String binaryStr = "";

        while (!binary.empty()) {
            binaryStr = binaryStr.concat(String.valueOf(binary.pop()));
        }

        System.out.println(binaryStr);
    }

}
