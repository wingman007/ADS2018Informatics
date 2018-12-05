def bubbleSort(alist):
    # obviously bubble sort.
    for passnum in range(len(alist) - 1, 0, -1):
        for i in range(passnum):
            if alist[i] > alist[i + 1]:
                temp = alist[i]
                alist[i] = alist[i + 1]
                alist[i + 1] = temp

#hardcoded list too lazy to do a input list. also not user friendly.
alist = [54, 26, 93, 17, 77, 31, 44, 55, 20]
# normal python sort

pythonSort = sorted(alist)
print "python sort -> %s" % pythonSort
bubbleSort(alist)
print "bubble sort -> %s "  % alist 
