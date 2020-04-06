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
	cout << "*** �������: x- ������ �������, y- ������ �������, z-������ ������� ***" << endl << endl;
	cout << "������ ����������� (����������� �� ���������) :   " << endl;
	triangle A; //����������� �� ���������
	A.outxyz();
	cout << "������ �����������(����������� �������������) :   " << endl;
	triangle B(3, 4, 5); //����������� �������������
	B.outxyz();
	cout << "������ ����������� (����������� ��������������) :   " << endl;
	triangle C(7); //����������� ��������������
	C.outxyz();
	cout << "��������� ����������� (���������������� ����) :" << endl;
	triangle D; //����������� �� ��������� + ���� � ����� 
	D.inxyz();
	D.outxyz();
	system("pause");
}