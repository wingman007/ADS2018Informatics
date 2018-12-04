# Induced path

# 
### Longest induced path
Finding the longest induced path in a hypercube is known as the snake-in-the-box problem.
In the mathematical area of graph theory, an induced path in an undirected graph G is a path that is an induced subgraph of G. That is,
it is a sequence of vertices in G such that each two adjacent vertices in the sequence are connected by an edge in G, and each two 
nonadjacent vertices in the sequence are not connected by any edge in G. An induced path is sometimes called a snake, and the problem of 
finding long induced paths in hypercube graphs is known as the snake-in-the-box problem.An induced path of length four in a cube.

Similarly, an induced cycle is a cycle that is an induced subgraph of G; induced cycles are also called chordless cycles or (when the 
length of the cycle is four or more) holes. An antihole is a hole in the complement of G, i.e., an antihole is a complement of a hole.

The length of the longest induced path in a graph has sometimes been called the detour number of the graph;[1] for sparse graphs, having 
bounded detour number is equivalent to having bounded tree-depth.[2] The induced path number of a graph G is the smallest number of induced 
paths into which the vertices of the graph may be partitioned,[3] and the closely related path cover number of G is the smallest number of 
induced paths that together include all vertices of G.[4] The girth of a graph is the length of its shortest cycle, but this cycle must be 
an induced cycle as any chord could be used to produce a shorter cycle; for similar reasons the odd girth of a graph is also the length of 
its shortest odd induced cycle.

# 
### Contents


    * Example
    * Characterization of graph families
    * Algorithms and complexity
    * Atomic cycles
    * Notes
    * References

# 
### Example


The illustration shows a cube, a graph with eight vertices and twelve edges, and an induced path of length four in this graph. A straightforward 
case analysis shows that there can be no longer induced path in the cube, although it has an induced cycle of length six. The problem of finding 
the longest induced path or cycle in a hypercube, first posed by Kautz (1958), is known as the snake-in-the-box problem, and it has been studied 
extensively due to its applications in coding theory and engineering.
Characterization of graph families

# 
### Graph families

Many important graph families can be characterized in terms of the induced paths or cycles of the graphs in the family.

    Trivially, the connected graphs with no induced path of length two are the complete graphs, and the connected graphs with no induced cycle 
are the trees.

    A triangle-free graph is a graph with no induced cycle of length three.
    The cographs are exactly the graphs with no induced path of length three.
    The chordal graphs are the graphs with no induced cycle of length four or more.
    The even-hole-free graphs are the graphs in containing no induced cycles with an even number of vertices.
    The trivially perfect graphs are the graphs that have neither an induced path of length three nor an induced cycle of length four.
    By the strong perfect graph theorem, the perfect graphs are the graphs with no odd hole and no odd antihole.
    The distance-hereditary graphs are the graphs in which every induced path is a shortest path, and the graphs in which every two induced paths 
between the same two vertices have the same length.
    The block graphs are the graphs in which there is at most one induced path between any two vertices, and the connected block graphs are the 
graphs in which there is exactly one induced path between every two vertices.

# 
### Algorithms and complexity


It is NP-complete to determine, for a graph G and parameter k, whether the graph has an induced path of length at least k. Garey & Johnson (1979) 
credit this result to an unpublished communication of Mihalis Yannakakis. However, this problem can be solved in polynomial time for certain graph 
families, such as asteroidal-triple-free graphs[5] or graphs with no long holes.[6]

It is also NP-complete to determine whether the vertices of a graph can be partitioned into two induced paths, or two induced cycles.[7] As a consequence,
 determining the induced path number of a graph is NP-hard.

The complexity of approximating the longest induced path or cycle problems can be related to that of finding large independent sets in graphs, by the 
following reduction.[8] From any graph G with n vertices, form another graph H with twice as many vertices as G, by adding to G n(n ? 1)/2 vertices having 
two neighbors each, one for each pair of vertices in G. Then if G has an independent set of size k, H must have an induced path and an induced cycle of 
length 2k, formed by alternating vertices of the independent set in G with vertices of I. Conversely, if H has an induced path or cycle of length k, any 
maximal set of nonadjacent vertices in G from this path or cycle forms an independent set in G of size at least k/3. Thus, the size of the maximum independent 
set in G is within a constant factor of the size of the longest induced path and the longest induced cycle in H. Therefore, by the results of Hastad (1996) on
 inapproximability of independent sets, unless NP=ZPP, there does not exist a polynomial time algorithm for approximating the longest induced path or the 
longest induced cycle to within a factor of O(n1/2-?) of the optimal solution.

Holes (and antiholes in graphs without chordless cycles of length 5) in a graph with n vertices and m edges may be detected in time (n+m2).[9]

# 
### Atomic cycles


Atomic cycles are a generalization of chordless cycles, that contain no n-chords. Given some cycle, an n-chord is defined as a path of length n connecting 
two points on the cycle, where n is less than the length of the shortest path on the cycle connecting those points. If a cycle has no n-chords, it is called 
an atomic cycle, because it cannot be decomposed into smaller cycles.[10] In the worst case, the atomic cycles in a graph can be enumerated in O(m2) time,
 where m is the number of edges in the graph. 