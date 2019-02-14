#Using While Loops
def count_substring(string, sub_string):
    result = 0
    i = 0
    length = len(sub_string)
    while( i <= len(string) - length):
        if(string[i:i+length] == sub_string):
            result = result + 1
        i = i+1
    return result

#Using List comprehensions
def count_substring1(string, sub_string):
    result = sum([1 for i in range(len(string) - len(sub_string) + 1) if string[i:i+len(sub_string)] == sub_string])
    return result

string = input().strip()
sub_string = input().strip()
count = count_substring1(string,sub_string)
print(count)

s=input()
print(any (c.isalnum() for c in s))
print(any (c.isalpha() for c in s))
print(any (c.isdigit() for c in s))
print(any (c.islower() for c in s))
print(any (c.isupper() for c in s))
