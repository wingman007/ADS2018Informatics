
'''
Example graph:

        3
       /
      /
     /
    /
   2 -- 5
       /
      /
     /
    /
   6 -- 7

   Divide the graph into two sets: A = { 2, 6 }, B = { 3, 5, 7 }.
   There are no arcs between two nodes from the same set, therefore the graph is bipartite.
'''

# Depth-First-Search modification:
def dfs_recursive(graph, vertex, path=[]):
    # Every iterated node.
    path += [vertex]

    flag = True
    for neighbor in graph[vertex]:
        # If there is a wrong connection in one of the nodes, switch the flag to False.
        for key, value in graph.items():
            if key is 2 and 6 in value:
                    flag = False
            elif key is 6 and 2 in value:
                    flag = False
            elif key is 3 and (5 in value or 7 in value):
                    flag = False
            elif key is 5 and (3 in value or 7 in value):
                    flag = False
            elif key is 7 and (5 in value or 3 in value):
                    flag = False
        if neighbor in path:
            break
        else:
            path = dfs_recursive(graph, neighbor, path)
    if flag:
        return 'The graph is bipartite'
    else:
        return 'The graph is not bipartite'

# Simpler representation of the nodes and their connection.
adjacency_matrix = {2: [3, 5],
                    3: [2], 5: [2, 6],
                    6: [5, 7], 7: [6]}

# Same graph with connections that make it not bipartite:
adjacency_matrix_2 = {2: [3, 5, 6],
                    3: [2], 5: [2, 6],
                    6: [5, 7], 7: [6, 5]}

print(dfs_recursive(adjacency_matrix, 3))
print(dfs_recursive(adjacency_matrix_2, 3))
