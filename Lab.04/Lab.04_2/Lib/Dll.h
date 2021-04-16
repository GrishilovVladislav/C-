#ifdef DLL_EXPORTS
#define DLL_API __declspec(dllexport)
#else
#define DLL_API __declspec(dllimport)
#endif

extern "C" {

    DLL_API double _stdcall Plus(double a, double b);
    DLL_API double _stdcall Minus(double a, double b);
    DLL_API double _stdcall  Multi(double a, double b);
    DLL_API double _stdcall  Div(double a, double b);
    DLL_API double _stdcall  Pow(double a, int x);
    DLL_API double _stdcall Abs(double a);
    DLL_API double __cdecl  Greater(double a, double b);
    DLL_API int _stdcall  Mod(int a, int b);

}