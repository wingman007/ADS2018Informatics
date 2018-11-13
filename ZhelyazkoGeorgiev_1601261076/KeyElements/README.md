~~~~~~~~~ Key Elements

1. Download the file to the directory where you want it to be stored.
2. press Ctrl + F5 to Rebuild and start the project.

~~ In this project I have to build a program which finds all the elements with a certain key. 

~ In it I have a List<Tuple<int, string>> in which I have hardcoded some numbers and next to them a couple of random words.
~ As far as I could understand the task I had the create a List with ints that take the role of "keys" and strings that take the role of "values". The task was to output all of the values that are under the same key number. I have not used the "Dictionary" because as far as I could see there couldn't have been equvalent "keys", maybe I am wrong. 
~ 1. In the project there is a "foreach" method that is storing the list in a single letter - s, and the calling it out in the console.
~ 2. The lookup method is for searching through the list and taking out all the same ints by printing them and next to them showing the words that are stored under that int.
~ 3. The "Console.ReadKey();" takes the same role as a breakpoint.