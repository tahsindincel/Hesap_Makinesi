using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesiKonsol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Hesap Makinesi- Değerleri ve İşaretleri giriniz. Çıkmak için ESC basınız.");
                bool esc = false;
                Console.Write("  Sayı giriniz:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Toplama: + \nÇıkarma: - \nÇarpma: * \nBölme: / \n İşlem Seçin:");
                char chr = Convert.ToChar(Console.ReadLine());
                Console.Write("  Sayı giriniz:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sonuç:= \nToplama: + \nÇıkarma: - \nÇarpma: * \nBölme: / \nÇıkış:E \n İşlem Seçin:");
                char chr2 = Convert.ToChar(Console.ReadLine());
                double c = 0;
                double f = 0;
                while (esc == false)
                {
                    if (chr2 == '=')
                    {
                        if (chr == '+')
                            f = a + b;
                        else if (chr == '-')
                            f = a - b;
                        else if (chr == '*')
                            f = a * b;
                        else if (chr == '/')
                        {
                            if (b == 0)
                                Console.WriteLine("Sıfıra Bölme İşlemi Tanımsızdır");
                            else
                                f = a / b;
                        }
                        else
                            Console.WriteLine("Bu Makine Sadece 4 işlem yapabilmektedir");
                        Console.Write(f);
                        esc = true;
                        Console.ReadKey();

                    }
                    else if (chr2 == 'E')
                    {
                        esc = true;


                    }
                    else
                    {
                        c = Hesaplama.Hesapla(a, b, chr, chr2);
                        b = c;
                        Console.Write("Sonuç:= \nToplama: + \nÇıkarma: - \nÇarpma: * \nBölme: / \nÇıkış:E \n İşlem Seçin:");
                        chr2 = Convert.ToChar(Console.ReadLine());
                        if (chr2 == '=')
                        {
                            Console.Write("Sonuç: " + c);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.Write("Doğru değerler gir");
            }
            Console.ReadKey();
        }
    }
    
}
