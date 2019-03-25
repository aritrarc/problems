""" Node is defined as
class node:
  def __init__(self, data):
      self.data = data
      self.left = None
      self.right = None
"""

isBst = True
def check_binary_search_tree_(root):
    traverse(root, -1)
    return isBst
    
def traverse(root, curr_max):
    if root == None:
        return curr_max
    curr_max = traverse(root.left, curr_max)
    if root.data > curr_max:
        curr_max = root.data
    else:
        global isBst
        isBst = False
    curr_max = traverse(root.right, curr_max)
    return curr_max