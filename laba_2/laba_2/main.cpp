#include "my.h"

void main()
{
	setlocale(LC_ALL, "Russian");
	cout << endl << "Re(z)\tIm(z)\t\t   ���������������� ���\t   ���������� ���";
	table(); // ����� ������� �������� 
	cout << endl << endl << "������� ����������� �����:" << endl;
	check(); // ��������� ����������������� � ����������� �����
	cout << endl;
	system("pause");
}
