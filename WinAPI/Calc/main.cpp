#include<Windows.h>
#include<string>
#include"resource.h"

//HWND hEdit = GetDlgItem(hwnd, IDC_EDIT1);
double a = 0;
double b = 0;
CHAR buffer[256]{};
CHAR s;


BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
VOID Count(HWND hEdit, double& a, char s, double& b);


int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, int nCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), 0, DlgProc, 0);
	return 0;
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:

		break;
	case WM_COMMAND:
	{
		switch (LOWORD(wParam))
		{
		case IDC_BUTTON0:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x30, 0); break;
		case IDC_BUTTON1:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x31, 0); break;
		case IDC_BUTTON2:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x32, 0); break;
		case IDC_BUTTON3:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x33, 0); break;
		case IDC_BUTTON4:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x34, 0); break;
		case IDC_BUTTON5:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x35, 0); break;
		case IDC_BUTTON6:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x36, 0); break;
		case IDC_BUTTON7:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x37, 0); break;
		case IDC_BUTTON8:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x38, 0); break;
		case IDC_BUTTON_POINT:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 46, 0); break;

		case IDC_BUTTON_PLUS:
		{

			s = '+';
			GetNumber();

		}
		break;
		case IDC_BUTTON_RESULT:
		{		GetNumber();
		switch (s)
		{
		case '+': a += b; break;
		case '-': a -= b; break;
		case '*': a *= b; break;
		case '/': a /= b; break;
		}
		b == 0;
		s = 0;
		strcpy(sz_buffer_a, std::to_string(a).)
		break;

		}
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
	}

	}
	return FALSE;
}

VOID Count(HWND hEdit, double& a, char s, double& b)
{
	GetWindowText(hEdit, buffer, 256);
	if (a == 0)
	{
		a = atof(buffer);
	}
	else
	{
		b = atof(buffer);
		a += b;
		strcpy(buffer, std::to_string(a).c_str());
		SetWindowText(hEdit, buffer);
	}
	if (b == 0)SetWindowText(hEdit, "");
	switch (s)
	{
	case '+':a += b; break;
	case '-':a -= b; break;
	case '*':a *= b; break;
	case '/':a /= b; break;
	}
}
VOID GetNumber() 
{
	GetWindowText(hEdit, sz_buffer, N_BUFFER_SIZE;)
}