#include "pch.h"
#include "framework.h"
#include "Dll.h"


double _stdcall Plus(double a, double b)
{
    return (a + b);
}
double _stdcall Minus(double a, double b)
{
    return (a - b);
}
double _stdcall  Multi(double a, double b)
{
    return (a * b);
}
double _stdcall  Div(double a, double b)
{
    return (a / b);
}
double _stdcall  Pow(double a, int x)
{
    double res = a;
    for (int i = 1; i < x; i++)
    {
        res = a * res;
    }
    return res;
}
double _stdcall Abs(double a) {
    int modifier = a < 0 ? -1 : 1;
    return a * modifier;
}
double __cdecl  Greater(double a, double b)
{
    if (a >= b) return a;
    else return b;
}
int _stdcall  Mod(int a, int b)
{
    return (a % b);
}