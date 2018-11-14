from time import time
import math
from random import sample

mark = 0

def tic():
    global mark
    mark = time()


def toc():
    global mark
    elapsed = time() - mark
    return elapsed
	

def insertion_sort(m):

    for j in range(1, len(m)):
        key = m[j]
        i = j - 1

        # shift everything greater than 'key' to it's right
        while i >= 0 and m[i] > key:
            m[i + 1] = m[i]
            i = i - 1

        m[i + 1] = key
    return m


def merge_sort(m):

    length = len(m)

    if length == 1:
        return m

    mid = int(math.floor(length / 2))

    left = merge_sort(m[0:mid])
    right = merge_sort(m[mid:length])

    return merge(left, right)


def merge(left, right):
    merged = []

    # while one of the list has some elements in it.
    while left or right:

        if left and right:
            if left[0] <= right[0]:
                key = left.pop(0)
            else:
                key = right.pop(0)
        elif left:
            key = left.pop(0)
        else:
            key = right.pop(0)

        merged.append(key)

    return merged


def quick_sort(m):

    if len(m) <= 1:
        return m

    pivot = m.pop()
    less = []
    great = []

    for i in m:
        if i <= pivot:
            less.append(i)
        else:
            great.append(i)

	return quick_sort(less) + [pivot] + quick_sort(great)


#this is the comparison.
def benchmark(func):

	n = [5, 10, 100, 1000, 10000]

	for i in n:
		unsorted = sample(range(0, i), i)
		tic()
		func(unsorted)
		print "%s(%d)   \t %.4gs" % (func.__name__, i, toc())

benchmark(insertion_sort)

benchmark(merge_sort)

benchmark(quick_sort)