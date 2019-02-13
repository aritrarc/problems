n = int(input())
dict = {}
student_marks = {}
for _ in range(n):
    name, *line = input().split()
    scores = list(map(float, line))
    student_marks[name] = scores
    dict[name] = scores
    
query_name = input()

if query_name in dict:
    #print("{0:.2f}".format(sum(dict[query_name])/len(dict[query_name]),2))
else:
    print("Doesn't exist")