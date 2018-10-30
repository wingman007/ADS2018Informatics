def convert(decimal):
    residue = None
    array_result = [] 
    # Initially assigned variable for further usage in the loop.
    exact_result = decimal
    while ( exact_result >= 0 ):
        residue = exact_result % 2
        exact_result = exact_result // 2
        array_result.append(residue)
        # When the integer result is 0, save the residue and finish.
        if exact_result is 0:
            break
    return array_result

print("Enter decimal:")
decimal = input()
integer_input = int(decimal)
final_result = convert(integer_input)

# Print the binary in reverse order.
print("Binary result: ")
for digit in reversed(final_result):
    # Stay on the same line. ( Append empty string after the last value )
    print(digit, end='')
