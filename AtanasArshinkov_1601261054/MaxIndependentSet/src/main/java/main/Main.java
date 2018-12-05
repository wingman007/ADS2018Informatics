package main;

public class Main {
    private static final int VERTICES_COUNT = 5;

    private static int[][] graph = {
            {0, 1, 0, 0, 0},
            {1, 0, 1, 0, 0},
            {0, 1, 0, 1, 1},
            {0, 0, 1, 0, 1},
            {0, 0, 1, 1, 0},
    };

    private static int[] S = new int[VERTICES_COUNT];
    private static int[] T = new int[VERTICES_COUNT];
    private static int sN = 0;
    private static int tN = 0;

    public static void main(String[] args) {
        System.out.println("Every max independent set in graph:");
        FindMaxIndependentSets(0);
    }

    private static void FindMaxIndependentSets(int last) {
        if (sN + tN == VERTICES_COUNT) {
            printSet();
            return;
        }

        for (int i = last; i < VERTICES_COUNT; i++) {
            if (S[i] == 0 && T[i] == 0) {
                for (int j = 0; j < VERTICES_COUNT; j++) {
                    if (graph[i][j] == 1 && S[j] == 0) {
                        S[j] = last + 1;
                        sN++;
                    }
                }

                T[i] = 1;
                tN++;
                FindMaxIndependentSets(i + 1); // Рекурсия
                T[i] = 0;
                tN--;
                for (int j = 0; j < VERTICES_COUNT; j++) {
                    if (S[j] == last + 1) {
                        S[j] = 0;
                        sN--;
                    }
                }
            }
        }
    }

    private static void printSet() {
        System.out.print("{ ");
        for (int i = 0; i < VERTICES_COUNT; i++) {
            if (T[i] == 1) {
                System.out.printf("%d ", i);
            }
        }
        System.out.println("}");
    }
}
