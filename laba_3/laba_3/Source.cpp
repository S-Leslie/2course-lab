#pragma once
#include <iostream>
#include <cstring>
using namespace std;

class String
{
	char* string; //
	int simvnum; //количество символов в строке

public:
	String()
	{	string = new char[1];
		simvnum = 1;
		string[0] = 0;
	}
	String(int n)
	{
		simvnum = n;
		string = new char[n];
		for (int i = 0; i < n; i++)
		{
			string[i] = 0; 
		}
	}
	String(char *s)
	{
		simvnum = strlen(s);
		string = new char[simvnum];

		for (int i = 0; i<simvnum; i++)
		{
			string[i] = s[i];
		}
	}
	String(String& s1)
	{
		simvnum = s1.simvnum;
		string = new char[simvnum];

		for (int i = 0; i<simvnum; i++)
		{
			string[i] = s1.string[i];
		}
	}
	friend String operator +(String& s1, String& s2);
	friend istream& operator >> (istream&, String& s1);
	friend ostream& operator <<(ostream&, const String& s1);
	friend String strncat(String& str1, String& str2, int num);
	friend String substr(String& s1, int numb, int slen);
	String& operator =(const String&);
};

String operator +(String& s1, String& s2)
{
	int newnum = s1.simvnum + s2.simvnum;
	String S(newnum);
	for (int i = 0; i< s1.simvnum; i++)
		S.string[i] = s1.string[i];
	for (int i = 0; i< s2.simvnum; i++)
		S.string[i + s1.simvnum] = s2.string[i];
	return S;
};
istream& operator >> (istream& s, String& s1)
{
	cout << "Введите строку: ";
	s >> s1.string;
	s1.simvnum = strlen(s1.string);
	return s;
};
ostream& operator <<(ostream& s, const String& s1)
{
	for (int i = 0; i < s1.simvnum; i++)
	{
		s << s1.string[i];
	}
	s << endl;
	return s;
};
String& String:: operator =(const String& s)
{
	if (this == &s) return *this;
	delete[] string;
	string = new char[simvnum = s.simvnum];
	for (int i = 0; i < simvnum; i++)
	{
		string[i] = s.string[i];
	}
	return *this;
};

String strncat(String& str1, String& str2, int num)
{
	String result = str1;
	String strend = substr(str2, 0, num);
	return result + strend;
}
;
String substr(String& s1, int numb, int slen)
{

	String podstr = new char[20];
	if (numb > s1.simvnum - 1)
	{

		podstr = s1;
	}
	else {
		int end = numb + slen;
		podstr.string = new char[end - numb + 1];
		podstr.simvnum = end - numb; //slen
		for (int i = numb, j = 0; i < end; i++, j++)
		{
			podstr.string[j] = s1.string[i];
		}
	}
	return podstr;
};

void main()
{
	setlocale(LC_ALL, ("rus"));
	String str_1(20);
	cin >> str_1;
	cout << endl << str_1;
	int n;
	cout << endl << "Введите точку отсчета";
	cin >> n;
	while (n<1)
	{
		cout << endl << "Номер символа не может быть меньше 1. Введите новый номер:";
		cin >> n;
	}
	int m;
	cout << endl << "Введите количество символов";
	cin >> m;
	while (m<1)
	{
		cout << endl << "Количество символов не может быть меньше 1. Введите новый номер:";
		cin >> m;
	}
	String k = substr(str_1, n, m);
	cout << endl << "Полученная подстрока:" << k;
	String str1(20);
	cin >> str1;
	cout << endl << str1;
	String str2(20);
	cin >> str2;
	cout << endl << str2;
	int num;
	cout << endl << "Введите количество символов";
	cin >> num;
	while (num<1)
	{
		cout << endl << "Количество символов не может быть меньше 1. Введите новое количество:";
		cin >> num;
	}
	String z = strncat(str1, str2, num);
	cout << endl << "Полученная строка:" << z;
	system("pause");
}