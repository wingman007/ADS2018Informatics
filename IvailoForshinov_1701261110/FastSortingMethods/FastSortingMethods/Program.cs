using System;

class Program
{

    static int tortoise = 1;
    static int hare = 1;
    const int finishline = 70;
    const int startingGate = 1;

    static void Main()
    { race(); }

    static void race()
    {

        Console.WriteLine(" On Your Mark,\n Get Set,\n Go !!!");
        Console.WriteLine();

        do
        {
            //calls tortoisemethod to determine variable tortoises value after each loop
            tortoisemethod();

            haresmethod();//calls haresmethod to determine variable hares value after each loop

            showrace();//prints the race

            // Slows down race
            for (int slowdown = 0; slowdown < 100000000; slowdown++) ;

        } while (tortoise < finishline && hare < finishline);

        if (tortoise == hare)
        {
            Console.WriteLine(" \n It’s a Tie !");
        }

        else if (tortoise > hare)
        {
            Console.WriteLine(" \n Tortoise Wins !");
        }

        else if (hare > tortoise)
        {
            Console.WriteLine(" \n Hare Wins !");
        }
        Console.WriteLine();
    }

    static void tortoisemethod()
    {
        //generates random number 1 thru 10 to use for variable move
        Random randomNumbers = new Random();
        int move = randomNumbers.Next(1, 11);
 
        if (move >= 1 && move <= 5)
        {
            tortoise += 3;
        }

        else if (move >= 6 && move <= 8)
        {
            ++tortoise;
        }

        else if (move == 9 || move == 10)
        {
            tortoise -= 6;
        }

        if (tortoise < startingGate)
        {
            tortoise = startingGate;
        }

        else if (tortoise > finishline)
        {
            tortoise = finishline;
        }

    }

    static void haresmethod()
    {
        Random randomNumbers = new Random();
        int move = randomNumbers.Next(1, 11);
      
        if (move == 1 || move == 2)
        {
            hare += 0;
        }

        else if (move == 3 || move == 4)
        {
            hare += 9;
        }

        else if (move == 5)
        {
            hare -= 12;
        }

        else if (move >= 5 && move <= 8)
        {
            ++hare;
        }

        else if (move == 9 || move == 10)
        {
            hare -= 2;
        }

        if (hare < startingGate)
        {
            hare = startingGate;
        }

        else if (hare > finishline)
        {
            hare = finishline;
        }
    }

    static void showrace()
    {
        for (int _move = 1; _move <= finishline; ++_move)
        {

            if (_move == tortoise && _move == hare)
            {
                Console.Write("Equal!");
            }

            else if (_move == tortoise)
            {
                Console.Write("T");
            }

            else if (_move == hare)
            {
                Console.Write("H");
            }

            else
            {
                Console.Write(" ");
            }
        }
    }
}