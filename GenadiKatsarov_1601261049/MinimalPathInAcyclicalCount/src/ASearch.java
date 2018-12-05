import java.util.ArrayList;
import java.util.HashMap;




public abstract class ASearch implements ISearch {
	protected Graph myGraph = new Graph();
	protected HashMap<String, Node> myMap = new HashMap<String, Node>();
	private ArrayList<Node> pathList = new ArrayList<Node>();

	public ASearch(Graph graph) {
		this.myGraph = graph;
		this.myMap = myGraph.getMap();
	}

	protected void setDepth(Node n) {
		for (Link l : n.getLinks()) {
			if (l.getToNode().getDepth() == -1)
				l.getToNode().setDepth(n.getDepth() + 1);
		}
	}

			
	protected ArrayList<Node> parentPrintPath(Node from, Node to) {

		if (from.getParent().equals(to)) {
			pathList.add(from);
			pathList.add(to);
			return pathList;
		}
		pathList.add(from);
		parentPrintPath(from.getParent(), to);
		return pathList;
	}

	

	
}
