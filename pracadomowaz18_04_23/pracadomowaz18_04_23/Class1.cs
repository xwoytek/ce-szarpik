using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracadomowaz18_04_23
{
    internal class wzory
    {
        public static double pkwadratu(int a)
        {
            return Math.Pow(a, 2);
        }
        public static double pprostokata(int a,int b)
        {
            return a * b;
        }
        public static double ptrjkt(int a, int h)
        {
            return a * h/2;
        }
        public static double prowno(int a, int h)
        {
            return a * h;
        }
        public static double ptrapez(int a,int b, int h)
        {
            return (a+b)*h/2;
        }
        public static double pkola(int r)
        {
            return Math.PI *Math.Pow(r,2);
        }
        public static double objszesc(int a)
        {
            return Math.Pow(a, 3);
        }
        public static double objprostopadloscianu(int a,int b, int c)
        {
            return a*b*c;
        }
        public static double objwalca(int r,int h)
        {
            return Math.PI * Math.Pow(r, 2)* h;
        }
        public static double objkuli(int r)
        {
            return Math.PI * Math.Pow(r, 2)*4/3;
        }
        public static double pszesc(int a)
        {
            return a*6;
        }
        public static double pprostopadl(int a,int b,int c)
        {
            return 2*a*b+2*b*c+2*a*c;
        }
        public static double pwalca(int r, int h)
        {
            return Math.PI * Math.Pow(r, 2)+Math.PI*2*r*h;
        }
    }
}
