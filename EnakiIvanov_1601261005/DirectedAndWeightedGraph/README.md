# Directed and weighted graph
Given a directed and two vertices ‘u’ and ‘v’ in it, find shortest path from ‘u’ to ‘v’ with exactly k edges on the path.
The graph is given as adjacency matrix representation where value of graph[i][j] indicates the weight of an edge from 
vertex i to vertex j and a value INF(infinite) indicates no edge from i to j.

For example consider the following graph. Let source ‘u’ be vertex 0, destination ‘v’ be 3 and k be 2. 
There are two walks of length 2, the walks are {0, 2, 3} and {0, 1, 3}. The shortest among the two is {0, 2, 3} and weight of path is 3+6 = 9.

![Directed graph](https://www.geeksforgeeks.org/wp-content/uploads/graph11-300x203.png)

The idea is to browse through all paths of length k from u to v using the approach discussed in the previous post and return weight of the shortest path.
A simple solution is to start from u, go to all adjacent vertices and recur for adjacent vertices with k as k-1, source as adjacent vertex and destination as v. 

### Prerequisites:
The application was built using Java.
This task is from the "Programming = ++ Algorithms" Book here is a link from where you can download the book: http://www.programirane.org/download-now/ Task number is 4.15, on page 254.

### Usage:
1. Copy the source code.
2. Go to: https://rextester.com/l/java_online_compiler
3. Paste it there and click 'execute'.
  
### Credit: 
https://www.geeksforgeeks.org/shortest-path-exactly-k-edges-directed-weighted-graph/
