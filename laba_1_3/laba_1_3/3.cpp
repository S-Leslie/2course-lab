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
	triangle() {
		x = 6; y = 8; z = 10;
		if ((x <= 0) || (y <= 0) || (z <= 0) || (x + y <= z) || (x + z <= y) || (y + z <= x))
			error();
	}
	triangle(int a, int b, int c) {
		x = a; y = b; z = c;
		if ((x <= 0) || (y <= 0) || (z <= 0) || (x + y <= z) || (x + z <= y) || (y + z <= x))
			error();
	}
	triangle(int a) {
		x = y = z = a;
		if ((x <= 0) || (y <= 0) || (z <= 0) || (x + y <= z) || (x + z <= y) || (y + z <= x))
			error();
	}
	friend triangle inxyz();//!!!!!!!
	friend void outxyz(triangle a);
};
triangle inxyz() {
	triangle a;
	cin >> a.x >> a.y >> a.z;
	if ((a.x <= 0) || (a.y <= 0) || (a.z <= 0) || (a.x + a.y <= a.z) || (a.x + a.z <= a.y) || (a.y + a.z <= a.x))
		a.error();
	return a;
}
void outxyz(triangle a) { cout << a.x << endl << a.y << endl << a.z << endl; }

void main()
{
	setlocale(LC_ALL, "Russian");
	cout << "*** Стороны: x- первая сторона, y- вторая сторона, z-третья сторона ***" << endl << endl;
	cout << "Первый треугольник (конструктор по умолчанию) :   " << endl;
	triangle A; //конструктор по умолчанию
	outxyz(A);
	cout << "Второй треугольник(конструктор инициализации) :   " << endl;
	triangle B(3, 4, 5); //конструктор инициализации
	outxyz(B);
	cout << "Третий треугольник (конструктор преобразования) :   " << endl;
	triangle C(7); //конструктор преобразования
	outxyz(C);
	cout << "Четвертый треугольник (пользовательский ввод) :" << endl;
	triangle D = inxyz();
	outxyz(D);
	system("pause");
}
