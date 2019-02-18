students, subjects = map(int,input().split())
A = []
for _ in range(subjects):
    A.append(map(float, input().split()))
print(zip(*A))
for i in zip(*A):
    print("{0:.1f}".format(sum(i)/len(i)))