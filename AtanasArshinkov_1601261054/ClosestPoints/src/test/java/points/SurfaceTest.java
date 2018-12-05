package points;

import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.assertEquals;


public class SurfaceTest {

    private List<Point> points = new ArrayList<Point>();

    @Before
    public void setUp() throws Exception {
        points.add(new Point(1, 1));
        points.add(new Point(1, 3));
        points.add(new Point(5, 8));
        points.add(new Point(10, 9));
    }

    @Test
    public void getShortestDistanceTest() {
        Surface surface = new Surface(points);
        System.out.println(surface.getShortestDistance());
        assertEquals(2.0, surface.getShortestDistance(), 0.0);
    }
}