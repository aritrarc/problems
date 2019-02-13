#Using If-else

N = 0
LI = []

for _ in range(N):
    command, *line = input().split()
    variables = list(map(int,line))

    if command == "print":
        print(LI)
    elif command == "append":
        LI.append(variables[0])
    elif command == "insert":
        LI.insert(variables[0], variables[1])
    elif command == "sort":
        LI.sort()
    elif command == "remove":
        LI.remove(variables[0])
    elif command == "reverse":
        LI.reverse()
    elif command == "pop":
        LI.pop()
    else:
        print("Command doesn't exist")

#Using eval&Join

n = int(input())
l = []
for _ in range(n):
    s = input().split()
    cmd = s[0]
    args = s[1:] 

    if cmd != "print":
        cmd += "(" + ",".join(args) + ")"
        eval("l." +cmd )
    else:
        print(l)
