//D-������� � ���� �������� ���������������� ������� � ���������� �� ������ � ����� �������

#include<iostream>
#include<conio.h>
using namespace std;

template<class T> class Element
{
	T data;
	Element*next, *undo;
public:
	Element(T a) { data = a; next = 0; };
	Element() {};
	template<class T> friend class Stack;
	template<class T> friend class Iterator;
	template<class T> friend ostream& operator<<(ostream& s, Stack<T> &a);
	};

template<class T> class Stack
{
	Element<T> *top;
	Element<T> *bot;
public:
	Stack() { top = 0, bot = 0; }
	~Stack();
	Stack(Stack<T>&);
	void add(T);
	void addToStart(T);
	void show();
	void dellToEnd();
	void dellToStart();
	template<class T> friend ostream& operator<<(ostream& s, Stack<T> &a);
	template<class T> friend class Iterator;
	Stack& operator=(Stack<T>&);
};

template<class T> class Iterator
{
	Stack<T> *D;
	Element<T>*cur;
public:
	Iterator(Stack<T>&d) { D = &d; cur = d.bot; }
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
	Element<T>* current() { return cur; }
	void set(Element<T>* p = 0) { cur = p; }
	template<class T> friend ostream& operator<<(ostream&s, Stack<T> &a);
};

template<class T> Stack<T>& Stack<T>::operator=(Stack<T> &st) //�������� ������������
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
	top = new Element<T>(st.top->data);
	Element<T>* temp = st.top->next;
	Element<T>* pnew = 0;
	Element<T>* pold = top;
	while (temp)
	{
		pnew = new Element<T>(temp->data);
		pold->next = pnew;
		if (!temp->next)
			bot = pnew;
		else
			pold = pnew;
		temp = temp->next;
	}
	return *this;
}

template<class T> ostream& operator<<(ostream& s, Stack<T> &a) //�������� ���������� ������
{
	{
		for (Element<T>* i = a.top; i != NULL; i = i->next)
			s << i->data << " ";
		return s;
	}
}


template<class T> Stack<T>::Stack(Stack<T>& sk)//����������� �����������
{
	if (!top) {
		top = new Element<T>;
	}
	top = new Element<T>(top->data);
	Element<T> *temp = top->next;
	Element<T> *now = 0;
	Element<T> *kold = top;
	while (temp) {
		now = new Element<T>(temp->data);
		now->undo = kold;
		kold->next = now;
		kold = now;
		temp = temp->next;
	}
}

template<class T> Stack<T>::~Stack() //����������
{
	while (top) {
		bot = top->next;
		delete top;
		top = bot;
	}
}

template<class T> void Stack<T>::addToStart(T el) //�������� � ������
{
	Element<T> *elem = new Element<T>();
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

template<class T> void Stack<T>::add(T el) //�������� � �����
{
	Element<T>  *elem = new Element<T>(el);
	if (top != 0) {
		elem->undo = bot;
		bot->next = elem;
		bot = elem;
	}
	else {
		top = bot = elem;
	}
}

template<class T> void Stack<T>::dellToStart() //������� �� ������
{
	Element<T> *elem = top->next;
	delete top;
	top = elem;
	//top->next = elem->next;
	top->undo = 0;
}

template<class T> void Stack<T>::dellToEnd() //������� �� �����
{
	Element<T> *elem = bot->undo;
	delete bot;
	bot = elem;
	elem->next = 0;
}

template<class T> void Stack<T>::show() //�������� ��������
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
	//Stack<int> over;
	Stack<char> over;
	//Iterator<int> kon(over);
	Iterator<char> kon(over);
	int k;
	char z;
	int a;
	cout << "������� ���������� ���������" << endl;
	cin >> k;
	cout << "������� ��������" << endl;
	for (int i = 0; i < k; i++)
	{
		cin >> z;
		over.add(z);
	}
	cout << "��������: " << endl;
	/*over.show();*/
	cout << over;
	cout << endl;
	over.dellToEnd();
	cout << "�������� � �����: " << endl;
	//over.show();
	cout << over;
	cout << endl;
	over.dellToStart();
	cout << "�������� �� ������: " << endl;
	//over.show();
	cout << over;
	cout << endl;
	cout << "������� ������� ��� ���������� � ������:" << endl;
	cin >> z;
	over.addToStart(z);
	//over.show();
	cout << over;
	cout << endl;
	cout << "������� ������� ��� ���������� � �����:" << endl;
	cin >> z;
	over.add(z);
	//over.show();
	cout << over;
	cout << endl;
	kon.reset();
	cout << kon.current() << endl;
	//cout << kon.peek() << endl;
	kon.next();
	cout << kon.current() << endl;
	//cout << kon.peek() << endl;
	cout << "������� ����� ��������, ����� �������� �� ������ ����������: " << endl;
	cin >> a;
	kon.roms(a);
	cout << kon.current() << endl;
	//cout << kon.peek() << endl;

	system("pause");
}