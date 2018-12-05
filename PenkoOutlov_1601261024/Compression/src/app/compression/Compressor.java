package app.compression;

public class Compressor {

    private Compressor() {
    }

    public static String nullSuppression(String[] values) {
        StringBuilder compressedString = new StringBuilder();

        int count = 0;

        for (int i = 0; i < values.length; i++) {
            if (values[i].equals("0")) {
                count++;

                if (i == values.length - 1) {
                    compressedString.append("0 ").append(count);
                }
            } else if (count != 0 && !values[i].equals("0")) {
                compressedString.append("0 ").append(count).append(" ").append(values[i]).append(" ");
                count = 0;
            } else {
                compressedString.append(values[i]).append(" ");
            }
        }

        compressedString.deleteCharAt(compressedString.length() - 1);

        return compressedString.toString();
    }

    public static String bitMapping(String[] values) {
        StringBuilder compressedString = new StringBuilder();

        String mapping = "";

        for (String currVal : values) {
            if (!currVal.equals("0")) {
                compressedString.append(currVal).append(" ");
                mapping += "1";
            } else {
                mapping += currVal;
            }
        }

        compressedString.deleteCharAt(compressedString.length() - 1);

        return Integer.valueOf(mapping, 2) + " " + compressedString.toString();
    }

    public static String runLengthCompression(String value) {
        StringBuilder compressedString = new StringBuilder();

        int count = 1;
        char currValue = value.charAt(0);

        for (int i = 1; i < value.length(); i++) {
            if (value.charAt(i) == currValue) {
                count++;

                if (i == value.length() - 1) {
                    compressedString.append(count).append(currValue);
                }
            } else if (count != 1 && value.charAt(i) != currValue) {
                compressedString.append(count).append(currValue);

                currValue = value.charAt(i);
                count = 1;
            } else {
                compressedString.append(currValue);

                currValue = value.charAt(i);
            }
        }

        return compressedString.toString();
    }
}
