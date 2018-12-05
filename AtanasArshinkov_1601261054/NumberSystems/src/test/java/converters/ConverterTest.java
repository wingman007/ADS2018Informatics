package converters;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ConverterTest {

    @Test
    public void convertDecToBin() {
        IConverter converter = new DecBinConverter();
        assertEquals("1010", converter.convert("10"));
        assertEquals("10110", converter.convert("22"));
        assertEquals("10100100101110", converter.convert("10542"));
    }

    @Test
    public void convertBinToDec() {
        IConverter converter = new BinDecConverter();
        assertEquals("10", converter.convert("1010"));
        assertEquals("22", converter.convert("10110"));
        assertEquals("10542", converter.convert("10100100101110"));
    }
}
