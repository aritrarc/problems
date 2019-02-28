from math import sqrt
class Complexnumbers:

    def __init__(self,real,imaginary):
        self.real = real
        self.imaginary = imaginary
    
    def conjugate(self):
        self.real = self.real
        self.imaginary = self.imaginary*(-1)
        return self

    def __add__(self, num1):
        return Complexnumbers(self.real + num1.real , self.imaginary + num1.imaginary)
    
    def __sub__(self, num1):
        return  Complexnumbers(self.real - num1.real , self.imaginary - num1.imaginary)
    
    def __mul__(self, num1):
        return Complexnumbers(self.real*num1.real - self.imaginary*num1.imaginary, self.real*num1.imaginary + self.imaginary*num1.real)

    def __truediv__(self, num1):
        num3 = Complexnumbers(num1.real, num1.imaginary*(-1))
        num4 = self*num3
        deno = num1*num3
        return Complexnumbers(num4.real/deno.real, num4.imaginary/deno.real )

    def mod(self):
        return Complexnumbers( sqrt(self.real**2 + self.imaginary**2) , 0.00)

    def __str__(self):
        return "{:.2f}{}{:.2f}i".format(self.real , "+" if self.imaginary >= 0 else "", self.imaginary)

num1 = Complexnumbers(*map(float, input().split()))
num2 = Complexnumbers(*map(float, input().split()))
print("\n".join(str(i) for i in [num1+num2,num1-num2,num1*num2,num1/num2,num1.mod(),num2.mod()]))
#print(*map(str, [x+y, x-y, x*y, x/y, x.mod(), y.mod()]), sep='\n')



