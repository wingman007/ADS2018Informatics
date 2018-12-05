package graph;

import java.util.HashSet;
import java.util.Set;

public class Node {

    private String name;

    private long weight;

    private Set<Node> edges;

    public Node(String name, long weight) {
        this.name = name;
        this.weight = weight;
        edges = new HashSet<>();
    }

    public void createEdge(Node destination) {
        edges.add(destination);
    }

    public String getName() {
        return name;
    }

    public long getWeight() {
        return weight;
    }

    public void setWeight(long weight) {
        this.weight = weight;
    }

    public Set<Node> getEdges() {
        return edges;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Node node = (Node) o;

        if (weight != node.weight) return false;
        if (name != null ? !name.equals(node.name) : node.name != null) return false;
        return edges != null ? edges.equals(node.edges) : node.edges == null;
    }
}
