from operator import itemgetter
# A = []
# for _ in range(int(input())):
#     name = input()
#     score = float(input())
#     A.append([name,score])
A = [["Harry",37.21], ["Berry",37.21],["Tina",37.2],["Akriti",41],["Harsh",39]]
C = list(set([y for x, y in A]))
D = set([y for x, y in A])
print(D)
B = sorted(list(set([marks for name, marks in A])))[1]
print(B)
for i in sorted(A):
    if i[1] == B:
        print(i[0])

