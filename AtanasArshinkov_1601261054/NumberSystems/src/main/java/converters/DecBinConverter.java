package converters;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class DecBinConverter implements IConverter {
    @Override
    public String convert(String number) throws NumberFormatException {
        int remainder;

        int result = Integer.parseInt(number);

        List<String> binaryList = new ArrayList<>();

        do {
            remainder = result % 2;
            binaryList.add(String.valueOf(remainder));
            result = result / 2;
        } while (result != 0);

        binaryList = reverse(binaryList);

        return buildNumber(binaryList);
    }

    private List<String> reverse(List<String> list) {
        List<String> reverse = new ArrayList<>(list);
        Collections.reverse(reverse);
        return reverse;
    }

    private String buildNumber(List<String> list) {
        StringBuilder builder = new StringBuilder();

        for (String digit : list) {
            builder.append(digit);
        }

        return String.valueOf(builder);
    }
}
