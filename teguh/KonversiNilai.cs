using System;
using System.Collections;
using System.Linq.Expressions;

class KonversiNilaiAngka
{
    static void Main(string[] args)
    {
        int nilai;

        Console.WriteLine("masukan nilai");
        nilai = Convert.ToInt16(Console.ReadLine());

        if(nilai >= 85 && nilai <= 100)
        {
            Console.WriteLine("Nilai A");
        }else if(nilai >=70 && nilai <=84)
        {
            Console.WriteLine("Nilai B");
        }
        else if (nilai >= 60 && nilai <70)
        {
            Console.WriteLine("Nilai C");
        }
        else if (nilai >= 50 && nilai < 60)
        {
            Console.WriteLine("Nilai D");
        }else if( nilai < 50)
        {
            Console.WriteLine("Nilai E");
        }
        else
        {
            Console.WriteLine("Invalid number");
        }


        switch (nilai)
        {
           case >=85 and <=100 :
                Console.WriteLine("Nilai A");
                break;
            case >= 70 and <= 84:
                Console.WriteLine("Nilai B");
                break;
            case >= 60 and < 70:
                Console.WriteLine("Nilai C");
                break;
            case >= 50 and <= 60:
                Console.WriteLine("Nilai D");
                break;
            case <50:
                Console.WriteLine("Nilai E");
                break;
            default:
                Console.WriteLine("Invalid Number");
                break;
        }

    }

}
