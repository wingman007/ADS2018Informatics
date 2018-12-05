package app;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Main {

    private static List<Point> convexHull(List<Point> points) {
        if (points.isEmpty()) {
            return Collections.emptyList();
        }

        points.sort(Point::compareTo);
        List<Point> result = new ArrayList<>();

        for (Point pt : points) {
            while (result.size() >= 2 && !checkCounterClockwise(result.get(result.size() - 2), result.get(result.size() - 1), pt)) {
                result.remove(result.size() - 1);
            }
            result.add(pt);
        }

        int t = result.size() + 1;
        for (int i = points.size() - 1; i >= 0; i--) {
            Point pt = points.get(i);
            while (result.size() >= t && !checkCounterClockwise(result.get(result.size() - 2), result.get(result.size() - 1), pt)) {
                result.remove(result.size() - 1);
            }
            result.add(pt);
        }

        result.remove(result.size() - 1);
        return result;
    }

    public static void main(String[] args) {
        List<Point> points = Arrays.asList(
                new Point(16, 3),
                new Point(12, 17),
                new Point(0, 6),
                new Point(-4, -6),
                new Point(16, 6),

                new Point(16, -7),
                new Point(16, -3),
                new Point(17, -4),
                new Point(5, 19),
                new Point(19, -8),

                new Point(3, 16),
                new Point(12, 13),
                new Point(3, -4),
                new Point(17, 5),
                new Point(-3, 15),

                new Point(-3, -9),
                new Point(0, 11),
                new Point(-9, -3),
                new Point(-4, -2),
                new Point(12, 10));

        List<Point> hull = convexHull(points);
        System.out.printf("Convex Hull: %s%n", hull);
    }

    private static boolean checkCounterClockwise(Point a, Point b, Point c) {
        return ((b.x - a.x) * (c.y - a.y)) > ((b.y - a.y) * (c.x - a.x));
    }

    private static class Point implements Comparable<Point> {

        private int x;
        private int y;

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        @Override
        public int compareTo(Point o) {
            return Integer.compare(x, o.x);
        }

        @Override
        public String toString() {
            return "(" + x + ", " + y + ")";
        }
    }
}
