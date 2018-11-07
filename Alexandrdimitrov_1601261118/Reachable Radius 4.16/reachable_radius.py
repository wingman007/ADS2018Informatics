from random import randint

class Natural_Number():
    def __init__(self, data, key):
        self.data = data
        self.key = key

natural_numbers_list = []
result_list = []
    
def print_final_result():
    print('\n\nThe element/s that satisfy the condition |k - x.key | <= d are:')
    for i in result_list:
        print(i.data, end=' | ')
    
def generate_number(quantity):
    # Generate the number and the key.
    for i in range(quantity):
        random_num = randint(0, 100)
        key_value = randint(100, 1000)
        new_element = Natural_Number(random_num, key_value)
        natural_numbers_list.append(new_element)

def search():
    for x in natural_numbers_list:
        if abs( k - x.key ) <= d:
            result_list.append(x)
    if len(result_list) is 0:
        print('\n\nNo such element!')
    else:
        print_final_result()

# The key values are typically larger.
k = randint(100, 1000)
d = randint(0, 100)

print("The key 'k' is: " + str(k))
print("The natural number 'd' is: " + str(d))
print('---------------------------------')
generate_number(10)
print('Generated list: ')
for e in natural_numbers_list:
    print(e.data, end=' | ')
search()
