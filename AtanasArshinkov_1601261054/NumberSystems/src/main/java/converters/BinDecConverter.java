package converters;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class BinDecConverter implements IConverter {

    @Override
    public String convert(String number) throws NumberFormatException {

        List<String> binaryList = new ArrayList<>(Arrays.asList(number.split("")));

        binaryList = reverse(binaryList);

        return buildNumber(binaryList);
    }

    private List<String> reverse(List<String> list) {
        List<String> reverse = new ArrayList<>(list);
        Collections.reverse(reverse);
        return reverse;
    }

    private String buildNumber(List<String> list) {
        int result = 0;

        for (int i = 0; i < list.size(); i++) {
            int currNumber = Integer.parseInt(list.get(i));
            if (currNumber == 0) continue;

            result = (int) (result + (Math.pow(2, i) * currNumber));
        }

        return String.valueOf(result);
    }
}
