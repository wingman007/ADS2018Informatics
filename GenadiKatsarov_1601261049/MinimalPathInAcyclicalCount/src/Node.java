import java.util.ArrayList;

public class Node {
	private Node parent = null;
	private double expense = Double.POSITIVE_INFINITY;
	private String name;
	private boolean isExpanded;
	private boolean isTested;
	private int depth = -1;
	private ArrayList<Link> links = new ArrayList<Link>();

	public Node(String name) {
		this.name = name;
	}


	public void resetNode() {
		isExpanded = false;
		isTested = false;
		setDepth(-1);
		parent=null;
		expense=Double.POSITIVE_INFINITY;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	public ArrayList<Link> getLinks() {
		return links;
	}

	public void setLinks(ArrayList<Link> links) {
		this.links = links;
	}

	public boolean isExpanded() {
		return isExpanded;
	}

	public void setExpanded(boolean isExpanded) {
		this.isExpanded = isExpanded;
	}

	public boolean isTested() {
		return isTested;
	}

	public void setTested(boolean isTested) {
		this.isTested = isTested;
	}

	public int getDepth() {
		return depth;
	}

	public void setDepth(int depth) {
		this.depth = depth;
	}

	public Node getParent() {
		return parent;
	}

	public void setParent(Node parent) {
		this.parent = parent;
	}

	public double getExpense() {
		return expense;
	}

	public void setExpense(double expense) {
		this.expense = expense;
	}


}
