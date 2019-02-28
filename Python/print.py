# Print each element of a list on a separate Line using List comprehension
#import numpy

A = [1, 2, 3, 4]
[print(i, end="\n") for i in A]

# s1 = set(map(int, input().split()))
# s2 = "intersection_update"
# s3 = (2, 3, 4)
# print(s1)
# eval("s1." + s2 + "s3" )

print([i*i for i in range(5)])

# for _ in range(int(input())):
#     try:
#         a,b = map(int, input().split())
#         print(int(a/b))
#     except ZeroDivisionError as e:
#         print("Error Code: integer division or modulo by zero")
#     except Exception as e:
#          print("Error Code:",e)

import re
for _ in range(int(input())):
    try:
        re.compile(input())
        print("True")
    except:
        print("False")
