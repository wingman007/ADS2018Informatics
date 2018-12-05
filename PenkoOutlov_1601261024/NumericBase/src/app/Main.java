package app;

import graph.Graph;
import graph.Node;

public class Main {

    public static void main(String[] args) {
        Graph graph = new Graph();

        Node a = new Node("A", 10L);
        Node b = new Node("B", 5L);
        Node c = new Node("C", 3L);

        graph.addNode(a);
        graph.addNode(b);
        graph.addNode(c);

        a.createEdge(b);
        a.createEdge(c);

        b.createEdge(a);
        b.createEdge(c);

        c.createEdge(a);
        c.createEdge(b);

        System.out.println(graph.getNumericBase().getName());
    }
}
