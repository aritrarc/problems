def decodeHuff(root, s):
    result = []
    curr_node = root
    for i in s:
        if int(i) == 1:
            curr_node = curr_node.right
        elif int(i) == 0:
            curr_node = curr_node.left
        if curr_node.left == None and curr_node.right == None:
            result.append(curr_node.data)
            curr_node = root
    print(''.join(result))