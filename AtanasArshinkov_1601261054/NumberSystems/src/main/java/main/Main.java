package main;

import converters.DecBinConverter;
import converters.IConverter;

public class Main {
    public static void main(String[] args) {
        IConverter converter = new DecBinConverter();

        String number = "10";

        System.out.println(converter.convert(number)); //1010, 2

    }
}
