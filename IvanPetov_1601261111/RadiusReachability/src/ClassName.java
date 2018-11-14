import java.util.ArrayList;
import java.util.Random;

public class ClassName {

    public static void main(String[] args) {
        Random random = new Random();
        Node[] numbers = new Node[50];
        Node k = new Node(60);
        int d = 14;


        for (int i = 0; i < 50; i++) {
            int curr = random.nextInt(100);
            numbers[i] = new Node(curr);
        }

        ArrayList<Node> result = findNums(numbers, k, d);

        if (result.isEmpty()) {
            System.out.println("No such elements! ");
        } else {
            System.out.println("The keys of the elements corresponding to the condition: ");
            print(result);
        }
    }

    public static void print(ArrayList<Node> nums) {
        for (Node x : nums) {
            System.out.printf("%d ", x.key);
        }
        System.out.println();
    }

    public static ArrayList<Node> findNums(Node[] numbers, Node k, int d) {
        ArrayList<Node> resultNums = new ArrayList<>();


        for (Node x : numbers) {
            if (Math.abs(k.key - x.key) <= d) {
                resultNums.add(new Node(x.key));
            }
        }

        return resultNums;
    }

    private static class Node {
        private int key;

        public Node(int key) {
            this.key = key;
        }
    }
}
