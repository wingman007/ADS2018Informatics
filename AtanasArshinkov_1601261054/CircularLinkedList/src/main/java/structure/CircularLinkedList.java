package structure;

public class CircularLinkedList<E> {
    private Node<E> head;

    private int size = 0;

    public void insertAtBeginning(E value) {
        Node<E> newNode = new Node<E>(value);
        if (head == null) {
            head = newNode;
            head.setNext(head);
        } else {
            Node<E> temp = head;
            newNode.setNext(temp);
            head = newNode;
        }
        size++;
    }

    public void insertAtTail(E value) {
        Node<E> newNode = new Node<E>(value);
        if (null == head) {
            head = newNode;
        } else {
            Node<E> temp = head;
            while (temp.getNext() != head) {
                temp = temp.getNext();
            }
            temp.setNext(newNode);
        }
        newNode.setNext(head);
        size++;
    }

    public void insertAtPosition(E value, int position) {
        if (position < 0 || position > size) {
            throw new IllegalArgumentException("Position is Invalid");
        }
        Node<E> newNode = new Node<E>(value);
        Node<E> tempNode = head;
        Node<E> prevNode = null;
        for (int i = 0; i < position; i++) {
            if (tempNode.getNext() == head) {
                break;
            }
            prevNode = tempNode;
            tempNode = tempNode.getNext();
        }
        prevNode.setNext(newNode);
        newNode.setNext(tempNode);
        size++;
    }

    public void deleteFromBeginning() {
        Node<E> temp = head;
        while (temp.getNext() != head) {
            temp = temp.getNext();
        }
        temp.setNext(head.getNext());
        head = head.getNext();
        size--;
    }

    public void deleteFromPosition(int position) {
        if (position < 0 || position >= size) {
            throw new IllegalArgumentException("Position is Invalid");
        }
        Node<E> current = head, previous = head;
        for (int i = 0; i < position; i++) {
            if (current.getNext() == head) {
                break;
            }
            previous = current;
            current = current.getNext();
        }
        if (position == 0) {
            deleteFromBeginning();
        } else {
            previous.setNext(current.getNext());
        }
        size--;
    }

    public Node<E> searchByIndex(int index) {
        if (index < 0 || index >= size) {
            throw new IndexOutOfBoundsException("Index is Invalid");
        }
        Node<E> temp = head;
        for (int i = 0; i < index; i++) {
            temp = temp.getNext();
        }
        return temp;
    }

    public Node<E> searchByValue(E value) {
        Node<E> temp = head;
        while (null != temp && temp.getItem() != value) {
            temp = temp.getNext();
        }
        if (temp.getItem() == value) {
            return temp;
        }
        return null;
    }

    public int size() {
        return size;
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public void display() {
        if (head == null) {
            System.out.println("List is Empty !!");
        } else {
            Node<E> temp = head;
            while (temp.getNext() != head) {
                System.out.println("Data at Node = " + temp.getItem());
                temp = temp.getNext();
            }
            System.out.println("Data at Node = " + temp.getItem());
        }
        System.out.println();
    }
}
