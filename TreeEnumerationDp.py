import sys
computed = []
oneNODElist = ["(.)"]
computed.append(oneNODElist)

def Tree(N):
    Tree_helpr(N)
    length = len(computed)
    for val in computed[length - 1]:
        print(val)

def Tree_helpr(N):
    if (N == 1):
        print("(.)")
    else:
        count = 1
        while (count < N):
            newcomputationlist = []
            lastindex = len(computed) - 1
            lastlist = computed[lastindex]
            for val in lastlist:
                newcomputationlist.append("("+val+".)")
                newcomputationlist.append("(."+val+")")
            if (count >= 2):
                index = 0
                while (index < count - 1):
                    lefttree = computed[count-2-index]
                    righttree = computed[index]
                    for lval in lefttree:
                        for rval in righttree:
                            newcomputationlist.append("("+lval+"."+rval+")")
                    index = index + 1
            computed.append(newcomputationlist)
            count = count + 1
Tree (int(sys.argv[1]))
