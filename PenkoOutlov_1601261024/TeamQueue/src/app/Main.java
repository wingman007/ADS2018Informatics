package app;

import java.util.*;

public class Main {


    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Random generator = new Random();

        TeamQueue<Integer> queue = new TeamQueue<>();

        // Input random values into the queue
        for (int i = 0; i < generator.nextInt(50) + 1; i++) {
            queue.add(generator.nextInt(100) + 1);
        }

        System.out.println("Created a queue of size: " + queue.size());
        queue.printQueue();

        System.out.print("Enter an amount of elements to add: ");
        int elementsToAdd = input.nextInt();

        for (int i = 0; i < elementsToAdd; i++) {
            System.out.print("Enter a value: ");
            int currentValue = input.nextInt();
            queue.add(currentValue);
        }

        int elementsToRemove = queue.size() / (generator.nextInt(4) + 1);
        System.out.println("Elements to remove: " + elementsToRemove);

        for (int i = 0; i < elementsToRemove; i++) {
            System.out.print(queue.dequeue() + ", ");
        }
        System.out.println();

        queue.printQueue();

        input.close();
    }
}
