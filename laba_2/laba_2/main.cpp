#include "my.h"

void main()
{
	setlocale(LC_ALL, "Russian");
	cout << endl << "Re(z)\tIm(z)\t\t   ѕользовательский тип\t   ¬строенный тип";
	table(); // вывод таблицы значений 
	cout << endl << endl << "¬ведите комплексное число:" << endl;
	check(); // сравнение пользовательского и встроенного типов
	cout << endl;
	system("pause");
}
