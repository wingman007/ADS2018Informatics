
public class MainClass {

	public static void main(String[] args) {
		Graph g=new Graph();
		Node n1=new Node("A");
		Node n2=new Node("B");
		Node n3=new Node("C");
		Node n4=new Node("D");
		Node n5=new Node("E");
		Node n6=new Node("F");
		Node n7=new Node("Sopot");
		g.addNode(n1);
		g.addNode(n2);
		g.addNode(n3);
		g.addNode(n4);
		g.addNode(n5);
		g.addNode(n6);
		g.addNode(n7);
	/*	g.addTwoWayRoute(n1, n2, 2);
		g.addTwoWayRoute(n1, n3, 3);
		g.addTwoWayRoute(n2, n3, 6);
		g.addTwoWayRoute(n2, n4, 3);
		g.addTwoWayRoute(n3, n4, 8);
		g.addTwoWayRoute(n4, n5, 1);
		g.addTwoWayRoute(n5, n6, 22);*/
		
		g.addTwoWayRoute(n1, n2, 2);
		g.addTwoWayRoute(n1, n3, 3);
		g.addTwoWayRoute(n2, n3, 1);
		g.addTwoWayRoute(n2, n4, 3);
		g.addTwoWayRoute(n3, n4, 8);
		g.addTwoWayRoute(n4, n5, 1);
		g.addTwoWayRoute(n5, n6, 22);
		
		
		DepthSearch a1=new DepthSearch(g);
		ShortestWaySearch a2=new ShortestWaySearch(g);
		
		if(a1.search("A", "Sopot")) {
			System.out.println("have a path");
		}else {
			System.out.println("don't have a path");
		}
		if(a2.search("A", "F")) {
			System.out.println("have a path");
			System.out.println("path is : ");
		
			for (int i=g.getPath().size()-1;i>=0;i--) {
				System.out.print(g.getPath().get(i).getName()+" , ");
			}
			
		}else {
			System.out.println("don't have a path");
		}

	}

}
