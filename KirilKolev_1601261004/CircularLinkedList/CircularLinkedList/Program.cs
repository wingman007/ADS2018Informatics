using System;
using System.Collections.Generic;

namespace CircularLinkedList
{
    class Program
    {
        static void Main( string[] args )
        {
            CircularLinkedList<int> list =  new CircularLinkedList<int>();
            list.AddLast( 1 );
            list.AddLast( 2 );
            list.AddLast( 3 );
            Console.WriteLine( "List count = {0}", list.Count );
            Console.WriteLine( "Head  = {0}", list.Head.Value );
            Console.WriteLine( "Tail  = {0}", list.Tail.Value );
            Console.WriteLine( "Head's Previous  = {0}", list.Head.Previous.Value );
            Console.WriteLine( "Tail's Next  = {0}", list.Tail.Next.Value );
            Console.WriteLine( "************List Items***********" );
            foreach ( int i in list )
            {
                Console.WriteLine(i);
            }

            Console.WriteLine( "************List Items in reverse***********" );
            for ( IEnumerator<int> r = list.GetReverseEnumerator(); r.MoveNext(); )
            {
                Console.WriteLine( r.Current );
            }

            Console.WriteLine( "************Adding a new item at first***********" );
            list.AddFirst( 0 );
            foreach ( int i in list )
            {
                Console.WriteLine( i );
            }

            Console.WriteLine( "************Adding item before***********" );
            list.AddBefore( 2, 11 );
            foreach ( int i in list )
            {
                Console.WriteLine( i );
            }

            Console.WriteLine( "************Adding item after***********" );
            list.AddAfter( 3, 4 );
            foreach ( int i in list )
            {
                Console.WriteLine( i );
            }

            Console.ReadKey();
        }
    }
}
