# This is my first python program

msg = "hello world"
print(msg)

# using Python as a calculator

num_1 = 6
num_2 = 3
num_3 = int(num_1/num_2)  #Typecasting
num_4 = float(num_1/num_2)

print(num_1 * num_2)
print(num_3)
print(num_4)
print(num_1/num_2)

# Floating point numbers

float_1 = 12.5
float_2 = 6.3

print( float_1 * float_2)
print(float_1 / float_2)

float_3 = float_1 / float_2
print(round(float_3, 2))

# String operations in python

string_1 = "hello World"
conact = string_1 + ' conactenated'
print(conact.capitalize())

print(conact[:5])
print(conact[4:])
print(conact[:])
print(conact[:-5])

# If Else

N = 3
X = N%2
if X != 0:
    print("Weird")
else:
    if N >=2 and N<=5:
        print("Not Weird")
    elif N >=6 and N<=20:
        print("Weird")
    else:
        print("Not Weird")

# While loops
n = 5
x = 0
while (x <= n):
    print(x**2)
    x = x + 1


#Function

def is_leap(year):
    leap = False
    if year%4 == 0:
        if year%100 == 0:
            if year%400 == 0:
                leap = True
        else:
            leap = True
    return leap

print(is_leap(1990))

#Print (without newline) 
x = 1
n = 5

while( x <= n):
    print(x,end="")
    x = x + 1



