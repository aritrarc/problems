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