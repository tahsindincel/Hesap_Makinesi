using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesiKonsol2
{
    internal class Hesaplama
    {
        public static double Hesapla(double a, double b, char chr, char chr2)
        {
            Console.Write("  Sayı giriniz: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double t = 0;
            if(chr2 == '*')
            {
                if (chr == '+') 
                {
                    t = (d * b) + a;
                }
                else if(chr== '-')
                {
                    t = (d * b) - a;
                }
                else if(chr == '*') 
                {
                    t = (d * b) * a;
                }
                else
                {
                    t = (d * b) / a;
                }
            }

            else if (chr2 == '/')
            {
                if (chr == '+')
                {
                    t = (b / d) + a;
                }
                else if (chr == '-')
                {
                    t = (b / d) - a;
                }
                else if (chr == '*')
                {
                    t = (b / d) * a;
                }
                else
                {
                    t = (b / d) / a;
                }
            }

            else if (chr2 == '+')
            {
                if (chr == '+')
                {
                    t = (d + b) + a;
                }
                else if (chr == '-')
                {
                    t = (d + b) - a;
                }
                else if (chr == '*')
                {
                    t = (d + b) * a;
                }
                else
                {
                    t = (d + b) / a;
                }
            }

            else
            {
                if (chr == '+')
                {
                    t = (b-d) + a;
                }
                else if (chr == '-')
                {
                    t = (b-d) - a;
                }
                else if (chr == '*')
                {
                    t = (b-d) * a;
                }
                else
                {
                    t = (b-d) / a;
                }
            }
            d = 0;
            return t;
        }
    }
}
