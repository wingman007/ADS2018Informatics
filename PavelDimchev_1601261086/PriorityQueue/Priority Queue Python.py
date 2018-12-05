# A simple class implementation of Priority Queue. It's On difficulty.
# using Queue.
# this is my class implementation of pri
class PriorityQueue(object):
    def __init__(self):
        self.queue = []

    def __str__(self):
        return " ".join([str(i) for i in self.queue])

    # checking if the queue is empty
    def isEmpty(self):
        return len(self.queue) == []

    # inserting an element in the queue
    def insert(self, data):
        self.queue.append(data)

    # popping an element based on Priority
    def delete(self):
        try:
            maximum = 0
            for i in range(len(self.queue)):
                if self.queue[i] > self.queue[maximum]:
                    maximum = i
            item = self.queue[maximum]
            del self.queue[maximum]
            return item
        except IndexError:
            print()
            exit()


if __name__ == "__main__":
    myQueue = PriorityQueue()
    myQueue.insert(12)
    myQueue.insert(1)
    myQueue.insert(14)
    myQueue.insert(7)
    print(myQueue)
    while not myQueue.isEmpty():
        print(myQueue.delete())