

print("Nice to meet you !")

while True:
    num = input("Please insert an integer:")
    #check if num is int if not return to input.
    if not type(num) == int:
        print("That's not an integer")
        continue
    # converting the integer
    binary = bin(num)
    # returning the value
    print "The binary number is: " + binary[2:] + 'exiting now....->'
    break

#convert to decimal from binary
print int("11111111", 2)