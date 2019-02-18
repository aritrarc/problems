def average(array):
    return sum(array)/len(array)

#arr = set(map(int, input().split()))
#print(average(arr))

#Symmetrica Difference

# n = map(int , input())
# M = set(map(int, input().split()))
# p = map(int , input())
# N = set(map(int, input().split()))
# #[ print (i, end="\n") for i in sorted(M.difference(N).union(N.difference(M)))]
# [ print (i, end="\n") for i in sorted(M.symmetric_difference(N))]


# No Idea
A = [1, 5, 3]
B = {1, 3}
C = {5, 7}
D =  B.difference(C)
E =  C.difference(B)
print(sum([ 1 if i in D else -1 if i in E else 0 for i in A]))
print(sum([(i in B) - (i in C) for i in A]))

# Set.add()
set_1 = set([])
# n = int(input())
# for _ in range(n):
#     set_1.add(input())
print(len(set_1))

# Set discard , remove , pop
#-----------------------------
# n = map(int, input())
# set_2 = set(map(int, input().split()))
# c = int(input())
# for _ in range(c):
#     cmd = input().split()
#     operator = cmd[0]
#     args = cmd[1:]
#     eval("set_2." +  operator + "(" + ",".join(args) + ")")
# print(sum(set_2))

#Union
# ------------------------
# n = map(int, input())
# set_1 = set(map(int, input().split()))
# m = map(int, input())
# set_2 = set(map(int, input().split()))
# print(len(set_1.union(set_2)))

#Intersection
# ------------------------
# n = map(int, input())
# set_1 = set(map(int, input().split()))
# m = map(int, input())
# set_2 = set(map(int, input().split()))
# print(len(set_1.intersection(set_2)))

#Set Mutations (union_update/ intersection_update/ difference_update/ symmetric_difference_update)
n = map(int, input())
set_1 = set(map(int, input().split()))
q = int(input())
for _ in range(q):
    s = input()
    set_2 = tuple(map(int, input().split()))
    eval("set_1." + s + str(set_2))
    #print(set_2)
print(set_1)

