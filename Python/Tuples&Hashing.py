#n = int(input())
n = 0
integer_list = []
#map(int, input().split())
#print(hash(tuple(integer_list)))


#change case

def swap(str):
    #result = ""
    # for i in str:
    #     if i.isupper():
    #         result += i.lower()
    #     else:
    #         result += i.upper()

    result = "".join( i.lower() if i.isupper() else i.upper() for i in str)
    print(result)

str = input()
swap(str)


