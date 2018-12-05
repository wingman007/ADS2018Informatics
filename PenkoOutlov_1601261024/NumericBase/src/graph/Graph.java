package graph;

import java.util.*;

public class Graph {

    private Set<Node> nodes;

    public Graph() {
        nodes = new HashSet<>();
    }

    public void addNode(Node node) {
        nodes.add(node);
    }

    public Set<Node> getNodes() {
        return nodes;
    }

    public Node getNumericBase() {
        Node base = null;

        for (Node currentNode : nodes) {
            if (isABaseNode(currentNode)) {
               if (base == null || (currentNode.getWeight() < base.getWeight())) {
                   base = currentNode;
               }
            }
        }

        return base;
    }

    private boolean isABaseNode(Node node) {
        return node.getEdges().size() == nodes.size() - 1;
    }
}
