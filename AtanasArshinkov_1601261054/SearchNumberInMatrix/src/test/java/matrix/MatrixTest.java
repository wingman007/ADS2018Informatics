package matrix;

import org.junit.Test;
import utils.Coordinates;

import static org.junit.Assert.*;

public class MatrixTest {

    private int[][] matrixArr = {{20, 10, 45, 67}, {72, 31, 12, 56}, {82, 24, 19, 17}};

    private Matrix matrix = new Matrix(matrixArr);

    @Test
    public void isInMatrixTest() {
        assertTrue(matrix.isInMatrix(45));
        assertTrue(matrix.isInMatrix(31));
        assertTrue(matrix.isInMatrix(82));

        assertFalse(matrix.isInMatrix(21));
    }

    @Test
    public void findNumberTest() {
        assertEquals(new Coordinates(0, 3), matrix.findNumber(67));
        assertEquals(new Coordinates(2, 2), matrix.findNumber(19));
        assertEquals(new Coordinates(1, 0), matrix.findNumber(72));
    }
}