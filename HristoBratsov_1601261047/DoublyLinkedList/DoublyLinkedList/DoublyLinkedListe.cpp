#include <cstdlib>
#include <iostream>

using namespace std;
struct list {
	int data;
	list* next;
	list* prev;
};
	void PrintReverse(list*tail);
	void PrintForward(list*head);
	


int main(int argc, char** argv) 

{

	list* head;
	list* tail;
	list* n;

	n = new list;
	n->data = 666;
	n->prev = NULL;
	head = n;
	tail = n;

	n = new list;
	n->data = 667;
	n->prev = tail;
	tail->next = n;
	tail = n;

	n = new list;
	n->data = 668;
	n->prev = tail;
	tail->next = n;
	tail = n;

	n = new list;
	n->data = 669;
	n->prev = tail;
	tail->next = n;
	tail = n;
	tail->next = NULL;

	n = new list;
	n->data = 670;
	n->prev = tail;
	tail->next = n;
	tail = n;
	tail->next = NULL;

	PrintForward(head);
	PrintReverse(tail);
	return 0;
}

void PrintForward(list * head)
{
	list* temp = head;

	while (temp != NULL)
	{
		cout << temp->data << " ";
		temp = temp->next;
	}
	cout << endl;
}
void PrintReverse(list*tail)
{
	list* temp = tail;

	while (temp != NULL)
	{
		cout << temp->data << " ";
		temp = temp->prev;
	}
	cout << endl;
	system("pause");
}