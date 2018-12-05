package app;

public class Converter {

    private Converter() {}

    public static long convertToDecimal(String binaryString) {
        long result = 0;

        int k = 0;
        for (int i = binaryString.length() - 1; i > -1; i--) {
            if (binaryString.charAt(i) != '0' && binaryString.charAt(i) != '1') {
                System.out.println("Invalid binary string.");
                return 0;
            } else {
                result += (long) Math.pow(2, k++) * (binaryString.charAt(i) - '0');
            }
        }

        return result;
    }

    public static String convertToBinary(long decimalValue) {
        String binaryString = "";

        while (decimalValue != 0) {
            binaryString = (decimalValue % 2) + binaryString;
            decimalValue /= 2;
        }

        return binaryString;
    }
}
