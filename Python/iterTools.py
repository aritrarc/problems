#itertools product
# from itertools import product 
# A = list(map(int, input().split()))
# B = list(map(int, input().split()))
# print(*product(A,B))

#itertools permutations , combination and combination with replacemenets
# from itertools import permutations
# str,k = input().split()
# print(*("".join(i) for i in permutations(sorted(str),int(k))), sep="\n")

# import itertools as itr
# *lst, k = map(int, input().split())
# print(list(itr.combinations_with_replacement(lst,k)))

#itertools odd even
import itertools as itr
import collections as col

iterable = itr.count(start=0, step=2)
print(list(next(iterable) for _ in range(20)))

iterable2 = itr.count(start=1, step=2)
print(list(next(iterable2) for _ in range(20)))

iterable3 = itr.count(start=100, step=100)
print(list(zip(iterable3,[1,2,3])))

print(list(itr.repeat(5,10)))

#Accumulate
print(list(itr.accumulate([1,2,3], lambda x,y: (x+y)*y)))
print(list(itr.accumulate([i for i in range(5)], lambda x,y: x+y)))

#firstorder &second order
# iterable4 = first_order(x = 0, y = 1, initial_val = 0)
# print(list(next(iterable4) for _ in range(5)))

#combinations
# str,k = input().split()
# for z in range(1, int(k)+1):
#     print(*("".join(i) for i in itr.combinations_with_replacement(sorted(str),int(z))), sep="\n")

rank = ['A','K','Q','J',10,9,8,7,6,5,4,3,2,1]
suit = ['S','H','D','C']
cards = itr.product(rank,suit)
print(*cards)

result = tuple((len(list(c)),int(k))  for k,c in itr.groupby("1222331"))
print(*result)

alphabets = "".join((input().split()))
print(alphabets)
print(*[len(list(c)) for k,c in itr.groupby(sorted(alphabets)) if k == 'a'])
print(col.Counter(alphabets))