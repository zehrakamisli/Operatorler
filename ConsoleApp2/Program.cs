using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama
            Console.WriteLine("********** Atama ve İşlemli Atama Operatörleri **********");
            Console.WriteLine();
            int x = 5;
            int y = 6;
            y = y + 1;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);
            Console.WriteLine();

            //Mantıksal Operatörler
            //&&,||,!
            Console.WriteLine("********** Mantıksal Operatörleri **********");
            Console.WriteLine();
            bool isSuccess = true;
            bool isCompleted = false;
            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            else if (isSuccess || isCompleted)
            {
                Console.WriteLine("Greats");
            }
            else if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }
            Console.WriteLine();
            //İlişkisel Operatörler
            /* 
             <
             >
             ==
             <=
             >=
             !=
             */
            Console.WriteLine("********** İlişkisel Operatörler **********");
            Console.WriteLine();
            int a = 5;
            int b = 9;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);
            Console.WriteLine();

            Console.WriteLine("********** Aritmetiksel Operatörler **********");
            Console.WriteLine();
            //+,-,*,/, %
            int s1=9;
            int s2=3;
            int sonuc1;
            sonuc1 = s1 / s2;
            Console.WriteLine(sonuc1);
            sonuc1 = s1 * s2;
            Console.WriteLine(sonuc1);
            sonuc1= s1 - s2;
            Console.WriteLine(sonuc1);
            sonuc1=sonuc1 + s2;
            Console.WriteLine(sonuc1);
            sonuc1=sonuc1 %s2;
            Console.WriteLine(sonuc1);

            Console.ReadLine();


        }
    }
}
