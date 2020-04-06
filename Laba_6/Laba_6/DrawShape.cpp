#include "stdafx.h"

class Shape
{
protected:
	int x_center;
	int y_center;

	COLORREF fillCol; //настоящее значение
	COLORREF lineCol; //для сохранения
public:
	Shape(int x, int y)
	{
		x_center = x;
		y_center = y;
	}
	void move(HWND hWnd, RECT rect)
	{
		x_center += 20;
		InvalidateRect(hWnd, &rect, TRUE);
	}
	void hide(HWND hWnd, RECT rect)
	{
		fillCol = COLORREF(RGB(0, 0, 0));
		InvalidateRect(hWnd, &rect, TRUE);
	}
	void show(HWND hWnd, RECT rect)
	{
		fillCol = lineCol;
		InvalidateRect(hWnd, &rect, TRUE);
	}
	virtual void drawObject(HDC hdc) = 0;

};

class  ARC : public Shape
{
	int width;
	int height;
	int modx;
	int mody;
public:
	ARC(int x = 0, int y = 0, int h = 0, int w = 0, int Col = RGB(0, 0, 0), int mod1x = 0, int mod1y = 0) :Shape(x, y)
	{
		x_center = x;
		y_center = y;
		height = h;
		width = w;
		lineCol = Col;
		fillCol = Col;
		modx = mod1x;
		mody = mod1y;
	}
	void drawObject(HDC hdc)
	{
		HPEN hPen = CreatePen(PS_SOLID, 5, fillCol);
		DeleteObject(SelectObject(hdc, hPen));

		Arc(hdc,
			x_center - width / 2, y_center,
			x_center + width / 2, y_center + height * 3 / 4,
			x_center - modx, y_center + mody,
			x_center + modx, y_center + mody
		);
		DeleteObject(SelectObject(hdc, hPen));
	}
};

class  LINE : public Shape
{
	int width;
	int height;
public:
	LINE(int x = 0, int y = 0, int h = 0, int w = 0, int Coll = RGB(0, 0, 0)) :Shape(x, y)
	{
		x_center = x;
		y_center = y;
		height = h;
		width = w;
		lineCol = Coll;
		fillCol = Coll;
	}
	void drawObject(HDC hdc)
	{

		HPEN hPen = CreatePen(PS_SOLID, 5, fillCol);
		HPEN holdPen = (HPEN)SelectObject(hdc, hPen);

		MoveToEx(hdc, x_center, y_center, NULL);
		LineTo(hdc, x_center + width, y_center + height);

		DeleteObject(SelectObject(hdc, holdPen));
		DeleteObject(SelectObject(hdc, hPen));
	};
};