solution = []

# Check if the current dollar batch forms a hyper increasing sequence
def feasable(current_element, previous_element, nominal_counter, current_list):
    if current_element is 0:
        if current_element >= nominal_counter * current_element:
            solution.append(current_list)
    elif current_element >= nominal_counter * previous_element:
        solution.append(current_list)


def general_function(n):
    for x in n:
        i = 0
        nominal_counter = 1
        while i < len(x):
            feasable(x[i], x[i-1], nominal_counter, x)
            i += 1
            nominal_counter += 1

# Find out the minimum amount of dollars that could form hyper increasing sequence.
def min_function(solution):
    minimum = solution[0]
    for i in solution:
        if len(i) < len(minimum):
            minimum = i
    return len(minimum)


nominal_list = [[ 1, 2, 5 ], [ 1, 5 ], [ 2, 10 ], [ 20, 50, 100 ], [ 5, 100 , 200 ]]

general_function(nominal_list)
#print(solution)
print('We take random number of dollars with random nominals as follows : ' + str(nominal_list))
print('The minimum amount of dollars requred to form a hyper increasing sequence is ' + str(min_function(solution)))