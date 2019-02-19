#itertools product
# from itertools import product 
# A = list(map(int, input().split()))
# B = list(map(int, input().split()))
# print(*product(A,B))

#itertools permutations
from itertools import permutations
str,k = input().split()
print(*("".join(i) for i in permutations(sorted(str),int(k))), sep="\n")
