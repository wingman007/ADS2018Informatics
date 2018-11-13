~~~~~~~~~~~~~~~~~ Getting the amount at a geometric progression
To show that the greedy notes algorithm will always work correctly if             currency denominations are of the type {1, c, c2, c3, ..., ck}, 
			  c >= 2, k >= 0

1. This task is build with Java in Eclipse Jee Neon.
2. To open this project you have to open the Program - Eclipse, go to File > Import > General > Exisiting Project in Workspace.
3. To run the program go to the top left and you will see a green arrow which you have to press in order to run it.

~ In this task, as far as I can understand, I have to create a program in which in the console you have to type in a number and the program will generate a sertain way this number could be devided in bulgarian currency - leva. 
~ When you open the project you will see two methods - "CountCurrency" where all the magic happens and "Main" where all the magic is printed out. 

~ In the "countCurrency" method there are two arrays in which there are stored
- 1."notes" - where the bulgarian levas are stored in a DESCENDING ORDER! Remember that if you ever have to write a program like this the currency numbers have to be in descending order, otherwise it won't work. 
~~~~ In the first for loop is where the counting of the notes are;
~~~~ In the second for loop is what it's printed out after we type in the number we want to devide.

~ In the "Main" method the is a Scanner which allows us to type in the console.
~~~~ the "amount = sc.nextInt();" is where the scanner is supposed to work. and on the next line we have a "sc.nextLine();" to read a line of input to read in the console.
~~~~ By calling the previous method with the "countCurrency" we call the amount. 
