package graph;

import java.util.LinkedHashSet;
import java.util.Set;

public class Node {

    private int value;

    private boolean traversed;

    private Set<Node> nodes;

    public Node(int value) {
        this.value = value;
        nodes = new LinkedHashSet<>();
    }

    public int getValue() {
        return value;
    }

    public void addNode(Node node) {
        nodes.add(node);
    }

    public Set<Node> getNodes() {
        return nodes;
    }

    public boolean isTraversed() {
        return traversed;
    }

    public void setTraversed(boolean traversed) {
        this.traversed = traversed;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Node node = (Node) o;

        return value == node.value;
    }
}
