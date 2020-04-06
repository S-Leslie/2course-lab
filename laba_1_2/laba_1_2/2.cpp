#include <iostream>
#include <math.h>
#include <string.h>
using namespace std;


// 14. Класс "Треугольник" с данными первая, вторая и третья стороны.

class triangle
{
	int x, y, z; // x-первая сторона
				 // y-вторая сторона
				 // z - третья сторона
	void error() { cout << "Ошибка! Нереальный объект!" << endl; system("pause"); exit(0); };
public:
	triangle();
	triangle(int a, int b, int c);
	triangle(int a);
	void inxyz();
	void outxyz();
};
triangle::triangle() {x = 6; y = 8; z = 10;
	if ((x <= 0) || (y <= 0) || (z <= 0) || (x + y <= z) || (x + z <= y) || (y + z <= x))
	error();}
triangle::triangle(int a, int b, int c) { x = a; y = b; z = c; 
	if ((x <= 0) || (y <= 0) || (z <= 0) || (x + y <= z) || (x + z <= y) || (y + z <= x))
	error();}
triangle::triangle(int a) { x = y = z = a;
	if ((x <= 0) || (y <= 0) || (z <= 0) || (x + y <= z) || (x + z <= y) || (y + z <= x))
	error();} //k
void triangle::inxyz() {cin >> x >> y >> z;
	if ((x <= 0) || (y <= 0) || (z <= 0) || (x + y <= z) || (x + z <= y) || (y + z <= x))
	error();}
void triangle::outxyz() { cout << x << endl << y << endl << z << endl; }
void main()
{
	setlocale(LC_ALL, "Russian");
	cout << "*** Стороны: x- первая сторона, y- вторая сторона, z-третья сторона ***" << endl << endl;
	cout << "Первый треугольник (конструктор по умолчанию) :   " << endl;
	triangle A; //конструктор по умолчанию
	A.outxyz();
	cout << "Второй треугольник(конструктор инициализации) :   " << endl;
	triangle B(3, 4, 5); //конструктор инициализации
	B.outxyz();
	cout << "Третий треугольник (конструктор преобразования) :   " << endl;
	triangle C(7); //конструктор преобразования
	C.outxyz();
	cout << "Четвертый треугольник (пользовательский ввод) :" << endl;
	triangle D; //конструктор по умолчанию + ввод и вывод 
	D.inxyz();
	D.outxyz();
	system("pause");
}