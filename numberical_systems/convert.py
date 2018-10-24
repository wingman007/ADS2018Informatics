
function convert(decimal):
    residue = None
    exact_result = decimal / 2
    array_result = []
    while ( exact_result is not 0 ):
        residue = exact_result % 2
        exact_result /= 2
        array_result.append(residue)
    return array_result

print("Enter decimal:")
decimal = input()
string_result = str(decimal)
final_result = convert(string_result)
print(final_result)
