	   ex. 5.100 - Check for isomorphism of graphs
    What is the best complexity you can achieve to check if any 			        columns are deformed?

1. what is isomorphic graphs?
- Two graphs which contain the same number of graph vertices connected in the same way are said to be isomorphic. Formally, two graphs  G and H with graph vertices V_n={1,2,...,n} are said to be isomorphic if there is a permutation p of V_n such that {u,v} is in the set of graph edges E(G) iff {p(u),p(v)} is in the set of graph edges E(H).

2. What is the best complexity you can achieve to check if two of the columns are isomorphic?
- The simplest way to check if two graph are isomorphic is to write down all possible permutations of the nodes of one of the graphs, and one by one check to see if it is identical to the second graph.
 If one of the permutations is identical, then the graphs are isomorphic. Of course it is very slow for large graphs.

~ Identical means that each node has edges going to the same nodes as does the node in the corresponding graph.
 The fastest known algorithms are 2^O((log n)^3), but they are complicated.

Credits: 
~ http://mathworld.wolfram.com/IsomorphicGraphs.html
~ https://www.quora.com/What-is-the-simplest-way-to-determine-if-two-graphs-are-isomorphic-when-we-only-know-the-edges-and-vertices

