package structure;

import org.junit.Ignore;
import org.junit.Test;

import static org.junit.Assert.*;

public class CircularLinkedListTest {

    @Test
    public void testInsertionAtHead() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        list.insertAtBeginning(4);
        assertEquals("4", String.valueOf(list.searchByIndex(0).getItem()));
        list.insertAtBeginning(5);
        assertEquals("5", String.valueOf(list.searchByIndex(0).getItem()));
        list.insertAtBeginning(9);
        assertEquals("9", String.valueOf(list.searchByIndex(0).getItem()));
        list.insertAtBeginning(13);
        assertEquals("13", String.valueOf(list.searchByIndex(0).getItem()));
    }

    /**
     * Test case for insertion at tail of linked list
     */
    @Test
    public void testInsertionAtTail() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        list.insertAtTail(4);
        assertEquals("4", String.valueOf(list.searchByIndex(0).getItem()));
        list.insertAtTail(5);
        assertEquals("5", String.valueOf(list.searchByIndex(1).getItem()));
        list.insertAtTail(9);
        assertEquals("9", String.valueOf(list.searchByIndex(2).getItem()));
        list.insertAtTail(13);
        assertEquals("13", String.valueOf(list.searchByIndex(3).getItem()));
    }

    /**
     * Test case for insertion at middle of linked list
     */
    @Test
    public void testInsertionAtMiddle() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        list.insertAtTail(4);
        assertEquals("4", String.valueOf(list.searchByIndex(0).getItem()));
        list.insertAtTail(5);
        assertEquals("5", String.valueOf(list.searchByIndex(1).getItem()));
        list.insertAtTail(9);
        assertEquals("9", String.valueOf(list.searchByIndex(2).getItem()));
        list.insertAtPosition(13, 1);
        assertEquals("13", String.valueOf(list.searchByIndex(1).getItem()));
        assertEquals("5", String.valueOf(list.searchByIndex(2).getItem()));
        assertEquals("9", String.valueOf(list.searchByIndex(3).getItem()));
    }

    /**
     * Test case for checking the size of linked list
     */
    @Test
    public void testSize() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        assertEquals(0, list.size());
        list.insertAtBeginning(3);
        assertTrue(list.size() != 0);
        assertEquals(1, list.size());
        list.insertAtTail(4);
        assertTrue(list.size() != 0);
        assertEquals(2, list.size());
    }

    /**
     * Test case for checking if liked list is empty
     */
    @Test
    public void testIsEmpty() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        assertTrue(list.isEmpty());
        list.insertAtBeginning(3);
        assertFalse(list.isEmpty());
    }

    /**
     * Test case for searching a element by index
     */
    @Test
    public void testSearchByIndex() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        list.insertAtTail(4);
        list.insertAtTail(7);
        list.insertAtTail(13);
        list.insertAtTail(19);
        list.insertAtTail(21);
        assertEquals("4", String.valueOf(list.searchByIndex(0).getItem()));
        assertEquals("7", String.valueOf(list.searchByIndex(1).getItem()));
        assertEquals("13", String.valueOf(list.searchByIndex(2).getItem()));
        assertEquals("19", String.valueOf(list.searchByIndex(3).getItem()));
        assertEquals("21", String.valueOf(list.searchByIndex(4).getItem()));
    }

    /**
     * Test case for searching a element by value
     */
    @Test
    public void testSearchByValue() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        list.insertAtBeginning(4);
        list.insertAtBeginning(7);
        list.insertAtBeginning(13);
        list.insertAtBeginning(19);
        list.insertAtBeginning(21);
        assertEquals("4", String.valueOf(list.searchByValue(4).getItem()));
        assertEquals("7", String.valueOf(list.searchByValue(7).getItem()));
        assertEquals("13", String.valueOf(list.searchByValue(13).getItem()));
        assertEquals("19", String.valueOf(list.searchByValue(19).getItem()));
        assertEquals("21", String.valueOf(list.searchByValue(21).getItem()));
    }

//    /**
//     * Test case to delete element from head
//     */
//    @Test
//    @Ignore
//    public void testDeleteFromHead() {
//        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
//        list.insertAtBeginning(4);
//        list.insertAtBeginning(7);
//        list.insertAtBeginning(13);
//        list.insertAtBeginning(19);
//        list.insertAtBeginning(21);
//        assertEquals("21", String.valueOf(list.searchByIndex(0).getItem()));
//        list.deleteFromBeginning();
//        assertEquals("7", String.valueOf(list.searchByIndex(0).getItem()));
//        list.deleteFromBeginning();
//        assertEquals("13", String.valueOf(list.searchByIndex(0).getItem()));
//        assertEquals(3, list.size());
//    }

    /**
     * Test case to delete element from tail
     */
    @Test
    public void testDeleteFromTail() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        list.insertAtTail(4);
        list.insertAtTail(7);
        list.insertAtTail(13);
        list.insertAtTail(19);
        list.insertAtTail(21);
        assertEquals("21", String.valueOf(list.searchByIndex(4).getItem()));
        assertEquals(5, list.size());
        list.deleteFromBeginning();
        assertEquals("21", String.valueOf(list.searchByIndex(3).getItem()));
        assertEquals(4, list.size());
    }

    /**
     * Test case to delete element from middle
     */
    @Test
    public void testDeleteFromMiddle() {
        CircularLinkedList<Integer> list = new CircularLinkedList<Integer>();
        list.insertAtTail(4);
        list.insertAtTail(7);
        list.insertAtTail(13);
        list.insertAtTail(19);
        list.insertAtTail(21);
        assertEquals("13", String.valueOf(list.searchByIndex(2).getItem()));
        list.deleteFromPosition(2);
        assertEquals("19", String.valueOf(list.searchByIndex(2).getItem()));
        list.deleteFromPosition(2);
        assertEquals("21", String.valueOf(list.searchByIndex(2).getItem()));
    }
}