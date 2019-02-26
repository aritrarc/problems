import itertools as itr
#import collections as cols
from collections import defaultdict
from collections import namedtuple

# k = int(input())
# Z = list(map(int, input().split()))
# alphabets = cols.Counter(Z)
# result = 0
# for _ in range(int(input())):
#     size, amount = map(int, input().split())
#     if size in alphabets:
#         if alphabets[size] > 0:
#             result = result + amount
#             alphabets[size] = alphabets[size] - 1
# print(result)


#------------ Default DICT ------------------------------
# n, m = map(int, input().split())
# d = defaultdict(list)
# for i in range(n):
#     d[str(input())].append(i+1)
# for _ in range(m):
#     val = str(input())
#     if val in d:
#         print(" ".join(str(i) for i in d[val]))
#     else:
#         print("-1")

#--------------- Named Tuple --------------------
# n = int(input())
# fields = input()
# total = 0
# Student = namedtuple('Student',fields)
# for _ in range(n):
#     student = Student(*input().split())
#     total += int(student.MARKS)
# print("{:.2f}".format(total/n))


#-------------- Ordered Dictionary -------------
# from collections import OrderedDict
# ordered_dict = OrderedDict()
# for _ in range(int(input())):
#     *item, price = input().split()
#     groc = " ".join(str(i) for i in item)
#     if groc in ordered_dict:
#         ordered_dict[groc] = int(ordered_dict[groc]) + int(price)
#     else:
#         ordered_dict[groc] = price
# for x,y in ordered_dict.items():
#     print(str(x) + " " + str(y))

# from collections import OrderedDict
# od = OrderedDict()
# for _ in range(int(input())):
#     word = input()
#     if word in od:
#         od[word] = int(od[word]) + 1
#     else:
#         od[word] = 1
# print(len(od))
# print(" ".join(str(i) for i in list(od.values())))

#-------------- Dequeue ------------------
# from collections import deque
# d = deque()
# for _ in range(int(input())):
#     ops , *args = input().split()
#     if len(args) > 0:
#         exp = "d." + ops + "(" + str(args) +")"
#         #getattr(d,ops,args)
#     else:
#         exp = "d." + ops + "()"
#         #getattr(d,ops)
#     eval(exp)
# print(" ".join(str(i[0]) for i in d))
#print(*[item for item in d])

#--------Piling up ----------------
from collections import deque
for _ in range(int(input())):
    n = int(input())
    A = list(input().split())
    d = deque(A)
    i = 0  
    j = len(A) - 1
    val = 0
    while abs(i - j) > 1:
        if A[i] >= A[j]:
            val = d.popleft()
            i = i+1
        else:
            val = d.pop()
            j = j-1
    if A[i] >= val or A[j] >= val:
        print("No")
    else:
        print("Yes")


