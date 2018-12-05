package app;

import java.util.ArrayList;
import java.util.List;

public class TeamQueue<T extends Comparable<T>> {

    private List<T> queue = new ArrayList<>();

    public void add(T element) {
        if (!queue.contains(element)) {
            queue.add(element);
        } else {
            int insertPosition = queue.lastIndexOf(element);
            queue.add(insertPosition, element);
        }
    }

    public T dequeue() {
        return queue.remove(0);
    }

    public void printQueue() {
        for (int i = 0; i < queue.size() - 1; i++) {
            System.out.print(queue.get(i) + ", ");
        }
        System.out.println(queue.get(queue.size() - 1));
    }

    public int size() {
        return queue.size();
    }
}
