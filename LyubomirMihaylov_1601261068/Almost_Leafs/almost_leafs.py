'''
Example tree graph:

      4
     / \
    2   5
   /   / \
  1   3   7
         /
        6

The almost leafs are: 2 and 7
'''
class Node:
    def __init__(self, data):
        self.left = None
        self.right = None
        self.data = data

class Binary_tree:
    def __init__(self):
        self.root = None

    leaf_list = []
    almost_leaf_list = []

    def add_almost_leaf(self, node):
        print('Almost leaf found!')
        print(node)
        self.almost_leaf_list.append(node)

    # If not there is no root node, make this one root.
    def add(self, data):
        if(self.root == None):
            self.root = Node(data)
        else:
            self._add(data, self.root)

    # As long as there is left or right child ( depending on the value's size ) continue down the tree untill it meets a leaf.
    def _add(self, data, node):
        if(data < node.data):
            if(node.left != None):
                self._add(data, node.left)
            else:
                node.left = Node(data)
        else:
            if(node.right != None):
                self._add(data, node.right)
            else:
                node.right = Node(data)

    # Traverse the tree for leafs.
    def find_leafs(self, node):
        if node:
            self.find_leafs(node.left)
            if( node.left is None and node.right is None ):
                print('Leaf found!')
                self.leaf_list.append(node.data)
            self.find_leafs(node.right)

    # Traverse the tree for almost leafs.
    def find_almost_leafs(self, node):
        print(node)
        if node:
            self.find_almost_leafs(node.left)
            if( node.left in self.leaf_list and node.right in self.leaf_list ):
                self.add_almost_leaf(node.data)
            elif( node.left in self.leaf_list and node.right is None ):
                self.add_almost_leaf(node.data)
            elif( node.right in self.leaf_list and node.left is None ):
                self.add_almost_leaf(node.data)
            else:
                print('Logical error.')
            self.find_almost_leafs(node.right)

tree = Binary_tree()
tree.add(4)
tree.add(2)
tree.add(5)
tree.add(1)
tree.add(3)
tree.add(7)
tree.add(6)
tree.find_leafs(tree.root)
tree.find_almost_leafs(tree.root)
print(tree.leaf_list)
print(tree.almost_leaf_list)
