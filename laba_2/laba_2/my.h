#pragma once
#include <iostream>
#include <cmath>
#include <complex>
#include "iomanip"
using namespace std;

class Complex
{
	double re, im; //re - �������������� �����, im - ������ ����� 
public:
	Complex() { re = im = 0; } // ����������� �� ���������
	Complex(double a) { re = a, im = 0; } // ����������� ��������������
	Complex(double a, double b) { re = a, im = b; } // ����������� ������������� 

	friend Complex Tg(Complex); // �������, ����������� ������� ������������ �����

	friend Complex operator * (Complex, Complex); // �������� ���������
	friend Complex operator + (Complex, Complex); // �������� ��������

	friend ostream& operator << (ostream&, Complex&); // ��������� �������� ������
	friend istream& operator >> (istream&, Complex&); // ��������� �������� �����

	double getre() { return re; } // �������, ������������ �������������� �����
	double getim() { return im; } // �������, ������������ ������ �����
};

Complex Tg(Complex z)
{
	Complex a;
	a.re = sin(z.re*2)/(cos(z.re*2)+cosh(z.im*2));
	a.im = sinh(z.im*2)/(cos(z.re * 2) + cosh(z.im * 2));
	return a;
}

Complex operator * (Complex x, Complex y) // ���������� ��������� *
{
	Complex b;
	b.re = x.re * y.re - x.im * y.im;
	b.im = x.re * y.im + x.im * y.re;
	return b;
}
Complex operator + (Complex x, Complex y) // ���������� ��������� -
{
	Complex c;
	c.re = x.re + y.re;
	c.im = x.im + y.im;
	return c;
}

ostream& operator << (ostream& S, Complex& a) { S << "(" << a.re << "," << a.im << ")";	return S; } // ���������� ��������� ������ <<
istream& operator >> (istream& S, Complex& a) { S >> a.re >> a.im;	return S; } // ���������� ��������� ����� >>

Complex Fun(double re, double im) // 2 + z tg(2z) ����������������
{
	Complex z = Complex(re, im);
	return (Complex(2) + z * Tg(Complex(2) * z));
}

complex <double> fun(double re, double im) // 2 + z tg(2z) ���������
{
	complex <double> z = complex <double>(re, im);
	return (complex <double>(2) + z * tan ((complex <double>) 2 * z));
}

void check() // ������� ��������� ���� �����
{
	Complex z;
	cin >> z;
	complex <double> z1(z.getre(), z.getim());
	Complex ans = Fun(z.getre(), z.getim());
	complex <double> aans = fun(real(z1), imag(z1));
	if ((real(aans) - ans.getre() < 0.0001) && (imag(aans) - ans.getim() < 0.0001))
		cout << endl << "���������� ���������:" << endl;
	else
		cout << endl << "���������� �� ���������:" << endl;
	cout << "\n f(z) = " << ans << "   (���������������� ���)" << endl << "f(z1) = " << aans << "   (���������� ���)" << endl;
}

void table() // ������� ������ ������� �����������
{
	for (double i = -1; i <= 1; i += 0.5)
		for (double j = -1; j <= 1; j += 0.5)
		{
			cout << "\n" << setw(4) << i << setw(8) << j << setw(16) << Fun(i, j) << setw(24) << fun(i, j);
		};
}
