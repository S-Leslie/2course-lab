// TYAPlr5.cpp : Defines the entry point for the application.
//

#include "stdafx.h"
#include "Laba_6.h"
#include "drawshape.cpp"

#define MAX_LOADSTRING 100

// Global Variables:
HINSTANCE hInst;								// current instance
TCHAR szTitle[MAX_LOADSTRING];					// The title bar text
TCHAR szWindowClass[MAX_LOADSTRING];			// the main window class name

												// Forward declarations of functions included in this code module:
ATOM				MyRegisterClass(HINSTANCE hInstance);
BOOL				InitInstance(HINSTANCE, int);
LRESULT CALLBACK	WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK	About(HWND, UINT, WPARAM, LPARAM);

int APIENTRY _tWinMain(_In_ HINSTANCE hInstance,
	_In_opt_ HINSTANCE hPrevInstance,
	_In_ LPTSTR    lpCmdLine,
	_In_ int       nCmdShow)
{
	UNREFERENCED_PARAMETER(hPrevInstance);
	UNREFERENCED_PARAMETER(lpCmdLine);

	// TODO: Place code here.
	MSG msg;
	HACCEL hAccelTable;

	// Initialize global strings
	LoadString(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
	LoadString(hInstance, IDC_LABA_6, szWindowClass, MAX_LOADSTRING);
	MyRegisterClass(hInstance);

	// Perform application initialization:
	if (!InitInstance(hInstance, nCmdShow))
	{
		return FALSE;
	}

	hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_LABA_6));

	// Main message loop:
	while (GetMessage(&msg, NULL, 0, 0))
	{
		if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}

	return (int)msg.wParam;
}



//
//  FUNCTION: MyRegisterClass()
//
//  PURPOSE: Registers the window class.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
	WNDCLASSEX wcex;

	wcex.cbSize = sizeof(WNDCLASSEX);

	wcex.style = CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc = WndProc;
	wcex.cbClsExtra = 0;
	wcex.cbWndExtra = 0;
	wcex.hInstance = hInstance;
	wcex.hIcon = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_LABA_6));
	wcex.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
	wcex.lpszMenuName = MAKEINTRESOURCE(IDC_LABA_6);
	wcex.lpszClassName = szWindowClass;
	wcex.hIconSm = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

	return RegisterClassEx(&wcex);
}

//
//   FUNCTION: InitInstance(HINSTANCE, int)
//
//   PURPOSE: Saves instance handle and creates main window
//
//   COMMENTS:
//
//        In this function, we save the instance handle in a global variable and
//        create and display the main program window.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
	HWND hWnd;

	hInst = hInstance; // Store instance handle in our global variable

	hWnd = CreateWindow(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, NULL, NULL, hInstance, NULL);

	if (!hWnd)
	{
		return FALSE;
	}

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);

	return TRUE;
}

//
//  FUNCTION: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  PURPOSE:  Processes messages for the main window.
//
//  WM_COMMAND	- process the application menu
//  WM_PAINT	- Paint the main window
//  WM_DESTROY	- post a quit message and return
//
//
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	int wmId, wmEvent;
	PAINTSTRUCT ps;
	RECT rect;
	GetClientRect(hWnd, &rect);
	HDC hdc;
	HBRUSH hBrush;
	LOGBRUSH lb;
	HBRUSH holdBrush;

	static ARC golova(500, 100, 100, 100, RGB(242, 216, 21), 0, 0);
	static ARC glaz(525, 135, 30, 30, RGB(255, 255, 255), 0, 0);
	static ARC zrach(528, 145, 10, 10, RGB(158, 235, 237), 0, 0);
	static ARC telo(400, 140, 180, 180, RGB(242, 216, 21), 0, 0);

	static LINE krilo1(400, 180, -55, -100, RGB(245, 216, 21));
	static LINE krilo2(300, 125, 100, 30, RGB(245, 216, 21));
	static LINE krilo3(330, 225, -42, 70, RGB(245, 216, 21));
	static LINE kluv1(540, 165, 0, 13, RGB(245, 100, 21));
	static LINE kluv2(548, 153, 10, 6, RGB(245, 100, 21));
	static LINE kluv3(548, 153, 10, -6, RGB(245, 100, 21));
	static LINE nogaL1(380, 277, 40, -5, RGB(245, 10, 21));
	static LINE nogaL2(377, 303, 10, -10, RGB(245, 10, 21));
	static LINE nogaL3(376, 303, 10, 10, RGB(245, 10, 21));

	static LINE nogaR1(423, 277, 40, 5, RGB(245, 10, 21));
	static LINE nogaR2(425, 304, 10, -7, RGB(245, 10, 21));
	static LINE nogaR3(426, 303, 10, 12, RGB(245, 10, 21));

	Shape* shapes[100] = { &golova, &glaz, &zrach, &telo, &krilo1, &krilo2, &krilo3, &kluv1, &kluv2, &kluv3, &nogaL1, &nogaL2, &nogaL3, &nogaR1, &nogaR2, &nogaR3 };

	switch (message)
	{
	case WM_COMMAND:
		wmId = LOWORD(wParam);
		wmEvent = HIWORD(wParam);
		// Parse the menu selections:
		switch (wmId)
		{
		case  ID_HIDE:
		{
			for (int i = 0; i < 16; i++)
			{
				shapes[i]->hide(hWnd, rect);
			}
		}
		break;

		case ID_SHOW:
		{
			for (int i = 0; i < 16; i++)
			{
				shapes[i]->show(hWnd, rect);
			}
		}
		break;

		case ID_MOVE:
		{

			for (int i = 0; i < 16; i++)
			{
				shapes[i]->move(hWnd, rect);
			}
		}
		break;
		case IDM_ABOUT:
			DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
			break;
		case IDM_EXIT:
			DestroyWindow(hWnd);
			break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
		}
		break;
	case WM_PAINT:
	{
		HDC hdc = BeginPaint(hWnd, &ps);
		GetClientRect(hWnd, &rect);
		lb.lbColor = RGB(0, 0, 0);
		lb.lbStyle = BS_SOLID;
		hBrush = CreateBrushIndirect(&lb);
		holdBrush = (HBRUSH)(SelectObject(hdc, hBrush));
		FloodFill(hdc, 0, 0, RGB(0, 0, 0));
		DeleteObject(SelectObject(hdc, holdBrush));
		DeleteObject(SelectObject(hdc, hBrush));

		for (int i = 0; i < 16; i++)
		{
			shapes[i]->drawObject(hdc);
		}
		EndPaint(hWnd, &ps);
	}
	break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hWnd, message, wParam, lParam);
	}
	return 0;
}

// Message handler for about box.
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		return (INT_PTR)TRUE;

	case WM_COMMAND:
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		break;
	}
	return (INT_PTR)FALSE;
}
