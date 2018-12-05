package converters;

public interface IConverter {
    /**
     * @param number the number which you want to convert
     * @return the converted number in the desired type
     */
    String convert(String number) throws NumberFormatException;
}
