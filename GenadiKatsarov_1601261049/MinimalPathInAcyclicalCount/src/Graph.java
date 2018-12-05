import java.util.ArrayList;
import java.util.HashMap;

public class Graph {
	private HashMap<String, Node> graph = new HashMap<String, Node>();

	private ArrayList<Node> path=new ArrayList<Node>();

   
	public void resetGraph() {

		for (Node value : graph.values()) {
			value.resetNode();
		}
		path.clear();
	
	}

	public void addNode(Node n) {
		graph.put(n.getName(), n);
	}
	

	public boolean addRoute(Node from, Node to, double lenght) {

		Link link = new Link(to, lenght);
		from.getLinks().add(link);
		return true;
	}

	public void addTwoWayRoute(Node from, Node to, double lenght) {
		addRoute(from, to, lenght);
		addRoute(to, from, lenght);
	}

	public HashMap<String, Node> getMap() {
		return graph;
	}


	public ArrayList<Node> getPath() {
		return path;
	}

	public void setPath(ArrayList<Node> path) {
		this.path = path;
	}

}
