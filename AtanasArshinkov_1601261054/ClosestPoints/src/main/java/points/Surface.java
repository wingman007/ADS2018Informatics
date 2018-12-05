package points;

import java.util.ArrayList;
import java.util.List;

public class Surface {
    private List<Point> points;

    public Surface(List<Point> points) {
        this.points = points;
    }

    public Surface() {
    }

    public void addPoint(Point point) {
        points.add(point);
    }

    public double getShortestDistance() {

        double min = Double.MAX_VALUE;

        for (int i = 0; i < points.size(); i++) {
            for (int j = 0; j < points.size(); j++) {
                if (j == i) continue;

                double result = calcDistance(points.get(i), points.get(j));

                if (result < min) {
                    min = result;
                }
            }
        }

        return min;
    }

    private double calcDistance(Point point1, Point point2) {

        double addend1 = Math.pow(point2.getX() - point1.getX(), 2);
        double addend2 = Math.pow(point2.getY() - point1.getY(), 2);

        return Math.sqrt(addend1 + addend2);
    }
}
