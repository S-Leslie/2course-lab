//14.D - ќчередь в виде простого двунаправленного списока с указателем на начало и конец очереди.
#include<iostream>
#include<conio.h>
using namespace std;

class Element
{
	int data;
	Element*next, *undo;
public:
	Element(int a) { data = a; next = 0; };
	Element() {};
	friend class Stack;
	friend class Iterator;
	friend ostream& operator<<(ostream& a, Stack &b);
};

class Stack
{
	Element *top, *bot;
public:
	Stack() { top = 0, bot = 0; }
	~Stack();
	Stack(const Stack&);
	void add(int);
	void addToStart(int);
	void show();
	void dellToEnd();
	void dellToStart();
	friend ostream& operator<<(ostream& s, Stack& a);
	friend class Iterator;
	Stack operator=(const Stack&);
};

class Iterator
{
	Stack*D;
	Element*cur;
public:
	Iterator(Stack&d) { D = &d; cur = d.bot; }
	int peek() { return cur->data; }
	void next() { cur = cur->next; }
	void reset() { cur = D->top; }
	void roms(int p) {
		cur = D->top;
		int z = 0;
		for (int i = 0; i < p; i++)
			D->top = D->top->next;
		cur = D->top;
	};
	Element*current() { return cur; }
	void set(Element* p = 0) { cur = p; }
	friend ostream& operator<<(ostream&s, Stack &a);
};

Stack Stack::operator=(const Stack &st) //оператор присваивани€
{
	if (this == &st) {
		return *this;
	}
	if (!st.top) {
		return *this;
	}
	while (top) {
		delete top;
	}
	top = new Element(st.top->data);
	Element* temp = st.top->next;
	Element* pnew = 0;
	Element* pold = top;
	while (temp)
	{
		pnew = new Element(temp->data);
		pold->next = pnew;
		if (!temp->next)
			bot = pnew;
		else
			pold = pnew;
		temp = temp->next;
	}
	return *this;
}

ostream& operator<<(ostream&s, Stack &a) //оператор потокового вывода
{
	{
		for (Element* i = a.top; i != NULL; i = i->next)
			s << i->data << " ";
		return s;
	}
}


Stack::Stack(const Stack& sk)//конструктор копировани€
{
	if (!top) {
		top = new Element;
	}
	top = new Element(top->data);
	Element *temp = top->next;
	Element *now = 0;
	Element *kold = top;
	while (temp) {
		now = new Element(temp->data);
		now->undo = kold;
		kold->next = now;
		kold = now;
		temp = temp->next;
	}
}

Stack::~Stack() //деструктор
{
	while (top) {
		bot = top->next;
		delete top;
		top = bot;
	}
}

void Stack::addToStart(int el) //добавить в начало
{
	Element *elem = new Element();
	elem->data = el;
	elem->next = top;
	if (top != 0) {
		top = elem;
		elem->undo = 0;
	}
	else {
		top = bot = elem;
	}
}

void Stack::add(int el) //добавить в конец
{
	Element  *elem = new Element(el);
	if (top != 0) {
		elem->undo = bot;
		bot->next = elem;
		bot = elem;
	}
	else {
		top = bot = elem;
	}
}

void Stack::dellToStart() //удалить из начала
{
	Element *elem = top->next;
	delete top;
	top = elem;
	top->undo = 0;
}

void Stack::dellToEnd() //удалить из конца
{
	Element *elem = bot->undo;
	delete bot;
	bot = elem;
	elem->next = 0;
}

void Stack::show() //просмотр элемента
{
	Element *elem = top;
	while (elem)
	{
		cout << elem->data << " ";
		elem = elem->next;
	}
}

void main() {
	setlocale(LC_ALL, ("rus"));
	Stack over;
	Iterator kon(over);
	int k;
	int z;
	cout << "¬ведите количество элементов" << endl;
	cin >> k;
	cout << "¬ведите элементы" << endl;
	for (int i = 0; i < k; i++)
	{
		cin >> z;
		over.add(z);
	}
	cout << "Ёлементы: " << endl;
	cout << over;
	cout << endl;
	over.dellToEnd();
	cout << "”даление с конца: " << endl;
	cout << over;
	cout << endl;
	over.dellToStart();
	cout << "”даление из начала: " << endl;
	cout << over;
	cout << endl;
	cout << "¬ведите элемент дл€ добавлени€ в начало:" << endl;
	cin >> z;
	over.addToStart(z);
	cout << over;
	cout << endl;
	cout << "¬ведите элемент дл€ добавлени€ в конец:" << endl;
	cin >> z;
	over.add(z);
	cout << over;
	cout << endl;
	kon.reset();
	cout << kon.current() << endl;
	cout << kon.peek() << endl;
	kon.next();
	cout << kon.current() << endl;
	cout << kon.peek() << endl;
	cout << "¬ведите номер элемента, адрес которого вы хотите посмотреть: " << endl;
	cin >> z;
	kon.roms(z);
	cout << kon.current() << endl;
	cout << kon.peek() << endl;
	system("pause");
}