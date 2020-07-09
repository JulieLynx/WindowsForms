#include<Windows.h>
#include<string>
#include"resource.h"

CONST UINT N_BUFFER_SIZE = 256;
CHAR sz_buffer[N_BUFFER_SIZE]{};
CHAR sz_buffer_a[N_BUFFER_SIZE]{};
CHAR sz_buffer_b[N_BUFFER_SIZE]{};
double a = 0, b = 0;
CHAR s;

HWND hEdit;

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
VOID GetNumber();

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, int nCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), 0, (DLGPROC)DlgProc, 0);
	return 0;
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		hEdit = GetDlgItem(hwnd, IDC_EDIT1);
		SetFocus(hEdit);
	}
	break;
	case WM_COMMAND:
	{
		if (LOWORD(wParam) >= 1000 && LOWORD(wParam) <= 1009)
		{
			GetWindowText(hEdit, sz_buffer, N_BUFFER_SIZE);
			if (strcmp(sz_buffer, sz_buffer_a) == 0)
			{
				SetWindowText(hEdit, "");
			}
			SendMessage(hEdit, WM_CHAR, LOWORD(wParam) - 952, 0);
		}
		switch (LOWORD(wParam))
		{/*
		case IDC_BUTTON(0-9):SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x3(0-9), 0); break;*/
		case IDC_BUTTON_POINT:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 46, 0); break;
		case IDC_BUTTON_BACK:SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 8, 0); break;
		case IDC_BUTTON_CLEAR:
		{
			//LPCSTR tx = "";
			HWND   hwndEdit1 = GetDlgItem(hwnd, IDC_EDIT1);
			SetWindowText(hwndEdit1, "");
			a = b = 0;
			//SendMessage(GetDlgItem(hwnd, IDC_EDIT1),  = ""); break;
		}
		case IDC_BUTTON_SQRT:
		{
			if (s)SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_RESULT, 0);
			s = 'pow2';
		}
		break;
		case IDC_BUTTON_POW2:
		{
			if (s)SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_RESULT, 0);
			s = 'pow2';
		
		}
		break;
		case IDC_BUTTON_POWN:
		{
			if (s)SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_RESULT, 0);
			s = 'pown';
			GetNumber();
		}
		break;
#pragma region sign

		case IDC_BUTTON_PLUS:
		{ if (s)SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_RESULT, 0);
		s = '+';
		GetNumber();
		}
		break;
		case IDC_BUTTON_MINUS:
		{ if (s)SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_RESULT, 0);
		s = '-';
		GetNumber();
		}
		break;
		case IDC_BUTTON_ASTER:
		{ if (s)SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_RESULT, 0);
		s = '*';
		GetNumber();
		}
		case IDC_BUTTON_SLASH:
		{ if (s)SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_RESULT, 0);
		s = '/';
		GetNumber();
		}
		break;
#pragma endregion

		case IDC_BUTTON_RESULT:
		{
			GetNumber();
			switch (s)
			{
			case '+': a += b; break;
			case '-': a -= b; break;
			case '*': a *= b; break;
			case '/': a /= b; break;
			case 'pown':
			{
				int buf = a;
				for (int i = 0; i < b-1; i++) { buf *= a; }
				a = buf;
			}
			break;
			}
			b == 0;
			s = 0;
			strcpy(sz_buffer_a, std::to_string(a).c_str());
			SetWindowText(hEdit, sz_buffer_a);
		}
		break;
		}
	}
	break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
	}
	return FALSE;
}

VOID GetNumber()
{
	GetWindowText(hEdit, sz_buffer, N_BUFFER_SIZE);
	if (a == 0)
	{
		strcpy(sz_buffer_a, sz_buffer);
		a = atof(sz_buffer);
	}
	else
	{
		strcpy(sz_buffer_b, sz_buffer);
		b = atof(sz_buffer);
	}
}