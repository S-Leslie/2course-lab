#pragma once
#include <iostream>
#include <cmath>
#include <complex>
#include "iomanip"
using namespace std;

class Complex
{
	double re, im; //re - действительная часть, im - мнимая часть 
public:
	Complex() { re = im = 0; } // конструктор по умолчанию
	Complex(double a) { re = a, im = 0; } // конструктор преобразования
	Complex(double a, double b) { re = a, im = b; } // конструктор инициализации 

	friend Complex Tg(Complex); // функция, вычисляющая тангенс комплексного числа

	friend Complex operator * (Complex, Complex); // оператор умножения
	friend Complex operator + (Complex, Complex); // оператор сложения

	friend ostream& operator << (ostream&, Complex&); // потоковая операция вывода
	friend istream& operator >> (istream&, Complex&); // потоковая операция ввода

	double getre() { return re; } // функция, возвращающая действительную часть
	double getim() { return im; } // функция, возвращающая мнимую часть
};

Complex Tg(Complex z)
{
	Complex a;
	a.re = sin(z.re*2)/(cos(z.re*2)+cosh(z.im*2));
	a.im = sinh(z.im*2)/(cos(z.re * 2) + cosh(z.im * 2));
	return a;
}

Complex operator * (Complex x, Complex y) // перегрузка оператора *
{
	Complex b;
	b.re = x.re * y.re - x.im * y.im;
	b.im = x.re * y.im + x.im * y.re;
	return b;
}
Complex operator + (Complex x, Complex y) // перегрузка оператора -
{
	Complex c;
	c.re = x.re + y.re;
	c.im = x.im + y.im;
	return c;
}

ostream& operator << (ostream& S, Complex& a) { S << "(" << a.re << "," << a.im << ")";	return S; } // перегрузка оператора вывода <<
istream& operator >> (istream& S, Complex& a) { S >> a.re >> a.im;	return S; } // перегрузка оператора ввода >>

Complex Fun(double re, double im) // 2 + z tg(2z) пользовательская
{
	Complex z = Complex(re, im);
	return (Complex(2) + z * Tg(Complex(2) * z));
}

complex <double> fun(double re, double im) // 2 + z tg(2z) системная
{
	complex <double> z = complex <double>(re, im);
	return (complex <double>(2) + z * tan ((complex <double>) 2 * z));
}

void check() // функция сравнения двух типов
{
	Complex z;
	cin >> z;
	complex <double> z1(z.getre(), z.getim());
	Complex ans = Fun(z.getre(), z.getim());
	complex <double> aans = fun(real(z1), imag(z1));
	if ((real(aans) - ans.getre() < 0.0001) && (imag(aans) - ans.getim() < 0.0001))
		cout << endl << "Результаты совпадают:" << endl;
	else
		cout << endl << "Результаты не совпадают:" << endl;
	cout << "\n f(z) = " << ans << "   (пользовательский тип)" << endl << "f(z1) = " << aans << "   (встроенный тип)" << endl;
}

void table() // функция вывода таблицы результатов
{
	for (double i = -1; i <= 1; i += 0.5)
		for (double j = -1; j <= 1; j += 0.5)
		{
			cout << "\n" << setw(4) << i << setw(8) << j << setw(16) << Fun(i, j) << setw(24) << fun(i, j);
		};
}
