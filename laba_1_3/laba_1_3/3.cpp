#include <iostream>
#include <math.h>
#include <string.h>
using namespace std;

// 14. ����� "�����������" � ������� ������, ������ � ������ �������.

class triangle
{
	int x, y, z; // x-������ �������
				 // y-������ �������
				 // z - ������ �������
	void error() { cout << "������! ���������� ������!" << endl; system("pause"); exit(0); };
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
	cout << "*** �������: x- ������ �������, y- ������ �������, z-������ ������� ***" << endl << endl;
	cout << "������ ����������� (����������� �� ���������) :   " << endl;
	triangle A; //����������� �� ���������
	outxyz(A);
	cout << "������ �����������(����������� �������������) :   " << endl;
	triangle B(3, 4, 5); //����������� �������������
	outxyz(B);
	cout << "������ ����������� (����������� ��������������) :   " << endl;
	triangle C(7); //����������� ��������������
	outxyz(C);
	cout << "��������� ����������� (���������������� ����) :" << endl;
	triangle D = inxyz();
	outxyz(D);
	system("pause");
}
