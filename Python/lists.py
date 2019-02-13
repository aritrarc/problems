N = int(input())
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
     
        