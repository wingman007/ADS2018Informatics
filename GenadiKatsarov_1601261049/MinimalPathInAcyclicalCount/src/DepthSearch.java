import java.util.ArrayList;



public class DepthSearch extends ASearch{
	public DepthSearch(Graph graph) {
		super(graph);
	}

	@Override
	public boolean search(String from, String to) {
		myGraph.resetGraph();
		if (!myMap.containsKey(from) || !myMap.containsKey(to)) {
			return false;
		}
		Node fromNode = myMap.get(from);
		fromNode.setDepth(0);
		ArrayList<Node> queue = new ArrayList<Node>();
		queue.add(fromNode);
		while (!queue.isEmpty()) {
			Node temp = queue.get(0);
			queue.remove(0);
			setDepth(temp);
	
			if (temp.getName().equals(to)) {
				
				return true;
			}
			temp.setTested(true);
			for (Link l : temp.getLinks()) {
				if (!l.getToNode().isTested() && !queue.contains(l.getToNode())) {
					queue.add(0, l.getToNode());

				}
			}
			temp.setExpanded(true);
		}

		return false;
	}


	private char[] printPath(Node temp) {
		// TODO Auto-generated method stub
		return null;
	}
}
