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
class Node:
    def __init__(self, data):
        self.data = data
        self.color = None
        self.conn_list = []
        
    def make_connections(self, connections):
        if not isinstance(connections, list):
            self.conn_list.append(connections)
        else:
            self.conn_list = connections

class Graph:
    def __init__(self):
        self.node_list = []

    def is_bipartite(self):
        # Traverse the graph.
        for n in self.node_list:
            # Traverse every node's conections.
            for x in n.conn_list:
                if x.color == n.color:
                    print('The graph is not bipartite!')
                    return False
        print('The graph is bipartite!')
        return True

    def color_graph(self, set_A, set_B):
        red_list = []
        blue_list = []
        for x in self.node_list:
            if x.data in set_A:
                x.color = 'red'
                red_list.append(x.data)
            elif x.data in set_B:
                x.color = 'blue'
                blue_list.append(x.data)
                
        print('Set A contains: ' + str(red_list))
        print('Set B contains: ' + str(blue_list))    
            
    def add(self, node):
        self.node_list.append(node)
        
set_A = [ 2, 6 ]
set_B = [ 3, 5, 7 ]

new_graph = Graph()
node_1 = Node(3)
node_2 = Node(2)
node_3 = Node(5)
node_4 = Node(6)
node_5 = Node(7)

# Create connections
node_1.make_connections([node_2])
node_2.make_connections([node_1, node_3])
node_3.make_connections([node_2, node_4])
node_4.make_connections([node_3, node_5])
node_5.make_connections([node_4])

new_graph.add(node_1)
new_graph.add(node_2)
new_graph.add(node_3)
new_graph.add(node_4)
new_graph.add(node_5)

new_graph.color_graph(set_A, set_B)

# Show bipartite
new_graph.is_bipartite()

# Show not-bipartite ( Wrong connections between node with value 3 and node with value 5 ).
node_1.make_connections([node_2, node_3])
new_graph.is_bipartite()
