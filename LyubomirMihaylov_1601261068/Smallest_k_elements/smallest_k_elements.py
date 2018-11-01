
random_list = [ 1.5, 5, -34, 3.7, 24, 0, 56, 7, 2, -45, 0.56, 15.687 ]
result_list = []

def smallest_k_elements(k_input):
    counter = 0
    while( counter < len(random_list)):
        if counter < k_input:
            result_list.append(random_list[counter])
        else:
            break
        counter+=1

print('Find the smallest k elements in the following list:\n')
print(random_list)
k_input = int(input('Enter k: '))
random_list.sort()
smallest_k_elements(k_input)

print('The smallest ' + str(k_input) + ' elements in the list are: ')
print(result_list)
print("Time complexity : O(2n+nlogn)")
print('================================================================================ \n')

def largest_k_element(random_list, k):
    print(random_list)
    counter_2 = 0
    while(counter_2 <= len(random_list)):
        if counter_2 == k - 1:
            print('The ' + str(k) + ' largest element in the list is : ')
            print(random_list[counter_2])
            break
        counter_2+=1

print('Find the largest k element in the list: ')
k = int(input('Enter k: '))
random_list.sort(reverse=True)
largest_k_element(random_list, k)

print("Time complexity : O(2nlogn)")
print('================================================================================ \n')

# Prioritized Queue
class Queue_Element:
    def __init__(self, value, priority):
        self.value = value
        self.priority = priority
        
# The larger the number - the higher the priority.
class Prioritized_Queue:
    def __init__(self):
        self.status = []                              
    
    def push(self, element):
        self.status.append(element)                   
        n = len(self.status)                          
        for i in range(n):   
            for j in range(0, n-1): 
                if self.status[j].priority > self.status[j+1].priority:
                    self.status[j], self.status[j+1] = self.status[j+1], self.status[j] 
    
    # Add an element at the start of the queue.    
    def pull(self):
        status_len = len(self.status)                 
        if status_len is not None:
            del self.status[status_len - 1]           
        else:
            print('There are no elements left in the queue!')
            return False
    
    # Show current state of the queue.
    def check(self):
        print('================ ')
        print('End of queue\n')
        for x in self.status:
            print(str(x.value) + ' : ' + str(x.priority), sep="|")
        print('\nStart of queue\n')
        print('================ ')
            
Stoqn = Queue_Element("Stqon", 2)                  
Dimitar = Queue_Element("Dimitar", 5)
Aleks = Queue_Element("Aleks", 11)
Stanimir = Queue_Element('Stan', 3)

# Example that the queue is working.
new_queue = Prioritized_Queue()                    
new_queue.push(Stoqn)                              
new_queue.push(Dimitar)
new_queue.push(Aleks)
new_queue.check()                                  
new_queue.push(Stanimir)
new_queue.check()

print('Make k pulls from the queue:')
k_queue = int(input('Enter k: '))

for i in range(k_queue):
    new_queue.pull()

print('The queue after k pulls')    
new_queue.check()
print("Time complexity : O(2n)")
print('================================================================================ \n')
print('First algorithm: O(2n+nlogn)')
print('Second algorithm: O(2nlogn)')
print('Third algorithm: O(2n)')
print('Conclusion: The first algo is the best in terms of time complexity.')
